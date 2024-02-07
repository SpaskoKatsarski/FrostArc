namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Authorization;

    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Community;
    using FrostArc.Data.Models;
    using FrostArc.Web.Infrastructire.Extensions;

    [Authorize]
    public class CommunityController : Controller
    {
        private ICommunityService communityService;
        private IModeratorService moderatorService;

        public CommunityController(ICommunityService communityService, IModeratorService moderatorService)
        {
            this.communityService = communityService;
            this.moderatorService = moderatorService;

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All(string? queryStr)
        {
            IEnumerable<CommunityAllViewModel> communities = await this.communityService
                .GetAllAsync(queryStr);

            return View(communities);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                bool isUserMember = await this.communityService.IsUserMemberAsync(id, User.GetId()!);
                bool isUserOwner = await this.communityService.IsUserOwnerAsync(id, User.GetId()!);

                if (isUserMember || isUserOwner)
                {
                    return RedirectToAction("Feed", new { id });
                }

                CommunityDetailsViewModel community = await this.communityService.GetForDetailsAsync(id);

                return View(community);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommunityFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = this.User.GetId()!;

            Community community = await this.communityService.CreateAsync(model, userId);

            return RedirectToAction("Details", new { Id = community.Id.ToString() });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string communityId)
        {
            string userId = this.User.GetId()!;
            bool isUserOwner = await this.communityService.IsUserOwnerAsync(communityId, userId);

            if (!isUserOwner)
            {
                return Forbid();
            }

            try
            {
                CommunityFormViewModel model = await this.communityService.GetForEditAsync(communityId);

                return View(model);
            }
            catch (ArgumentException ae)
            {
                return Forbid(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CommunityFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.communityService.EditAsync(model);

                return RedirectToAction("Feed", "Community", new { id = model.Id });
            }
            catch (ArgumentException ae)
            {
                return Forbid(ae.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Join(string id)
        {
            try
            {
                string userId = User.GetId()!;
                await this.communityService.AddUserToCommunityAsync(id, userId);
            }
            catch (ArgumentException ae)
            {
                return RedirectToAction("Details", "Community", new { id });
            }

            return RedirectToAction("Feed", new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Feed(string id)
        {
            try
            {
                bool isMember = await this.communityService.IsUserMemberAsync(id, User.GetId()!);
                bool isOwner = await this.communityService.IsUserOwnerAsync(id, User.GetId()!);

                if (!isMember && !isOwner)
                {
                    return RedirectToAction("Details", "Community", new { id });
                }

                CommunityFeedViewModel model = await this.communityService.GetForFeedAsync(id);

                return View(model);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Members(string communityId, string? queryStr)
        {
            try
            {
                CommunityUsersViewModel communityUsers = await this.communityService.GetCommunityUsersAsync(communityId, queryStr);

                return View(communityUsers);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Kick(string userId, string communityId)
        {
            if (!await this.communityService.IsUserOwnerAsync(communityId, User.GetId()!))
            {
                return Forbid();
            }

            try
            {
                await this.communityService.RemoveUserFromCommunityAsync(communityId, userId);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }

            return RedirectToAction("Members", new { communityId });
        }

        [HttpGet]
        public async Task<IActionResult> Promote(string userId, string communityId)
        {
            try
            {
                await this.moderatorService.PromoteAsync(userId, communityId);
            }
            catch (ArgumentException ae)
            {
                //TempData[ErrorMessage] = ae.Message;
            }

            return RedirectToAction("Members", "Community", new { communityId });
        }

        [HttpGet]
        public async Task<IActionResult> Demote(string userId, string communityId)
        {
            try
            {
                await this.moderatorService.DemoteAsync(userId, communityId);
            }
            catch (ArgumentException ae)
            {
                //TempData[ErrorMessage] = ae.Message;
            }

            return RedirectToAction("Members", "Community", new { communityId });
        }

        [HttpGet]
        public async Task<IActionResult> Leave(string userId, string communityId)
        {
            bool isMember = await this.communityService.IsUserMemberAsync(communityId, userId);
            bool isOwner = await this.communityService.IsUserOwnerAsync(communityId, userId);

            if (isMember && !isOwner)
            {
                await this.communityService.RemoveUserFromCommunityAsync(communityId, userId);
            }

            return RedirectToAction("Details", "Community", new { id = communityId });
        }
    }
}

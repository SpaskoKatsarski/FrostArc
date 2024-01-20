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

        public CommunityController(ICommunityService communityService)
        {
            this.communityService = communityService;
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
        public async Task<IActionResult> Join(string id)
        {
            try
            {
                string userId = User.GetId()!;
                await this.communityService.AddUserToCommunityAsync(id, userId);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
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
                    return BadRequest("You should join this community in order to access its Feed.");
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
        public async Task<IActionResult> Members(string communityId)
        {
            if (!await this.communityService.IsUserOwnerAsync(communityId, User.GetId()!))
            {
                return Forbid();
            }

            try
            {
                CommunityUsersViewModel communityUsers = await this.communityService.GetCommunityUsersAsync(communityId);

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
    }
}

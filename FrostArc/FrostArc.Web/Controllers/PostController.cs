namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.Infrastructire.Extensions;
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Comment;
    using static FrostArc.Common.DataValidationConstants;

    [Authorize]
    public class PostController : Controller
    {
        private IPostService postService;
        private IModeratorService moderatorService;
        private ICommunityService communityService;

        public PostController(IPostService postService, IModeratorService moderatorService, ICommunityService communityService)
        {
            this.postService = postService;
            this.moderatorService = moderatorService;
            this.communityService = communityService;
        }

        [HttpGet]
        public IActionResult Create(string communityId)
        {
            PostFormViewModel model = new PostFormViewModel()
            {
                UserId = User.GetId()!,
                CommunityId = communityId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.postService.CreateAsync(model);

            return RedirectToAction("Feed", "Community", new { id = model.CommunityId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string postId, string? communityId)
        {
            try
            {
                string userId = User.GetId()!;

                bool isUserCreator = await this.postService.IsUserCreatorAsync(postId, userId);
                bool hasAccess = true;

                if (communityId != null)
                {
                    hasAccess = await this.moderatorService.IsModeratorAsync(userId, communityId) ||
                        await this.communityService.IsUserOwnerAsync(communityId, userId) ||
                        isUserCreator;
                }
                else
                {
                    hasAccess = isUserCreator;
                }

                if (!hasAccess)
                {
                    //TempData
                    throw new InvalidOperationException("User is not the creator of the post!");
                }

                PostFormViewModel post = await this.postService.GetForEditAsync(postId);

                return View(post);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (InvalidOperationException ioe)
            {
                return Forbid(ioe.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string userId = User.GetId()!;

            bool isUserCreator = await this.postService.IsUserCreatorAsync(model.Id!, userId);
            bool hasAccess = true;

            if (model.CommunityId != null)
            {
                hasAccess = await this.moderatorService.IsModeratorAsync(userId, model.CommunityId) ||
                    await this.communityService.IsUserOwnerAsync(model.CommunityId, userId) ||
                    isUserCreator;
            }
            else
            {
                hasAccess = isUserCreator;
            }

            if (!hasAccess)
            {
                //TempData
                throw new InvalidOperationException("User is not the creator of the post!");
            }

            try
            {
                await this.postService.EditAsync(model);

                return RedirectToAction("Feed", "Community", new { id = model.CommunityId });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string postId, string? communityId)
        {
            string userId = User.GetId()!;

            bool isUserCreator = await this.postService.IsUserCreatorAsync(postId, userId);
            bool hasAccess = true;

            if (communityId != null)
            {
                hasAccess = await this.moderatorService.IsModeratorAsync(userId, communityId) ||
                    await this.communityService.IsUserOwnerAsync(communityId, userId) || 
                    isUserCreator;
            }
            else
            {
                hasAccess = isUserCreator;
            }

            if (!hasAccess)
            {
                //TempData
                throw new InvalidOperationException("User is not the creator of the post!");
            }

            try
            {
                PostDeleteViewModel model = await this.postService.GetForDeleteAsync(postId);

                return View(model);
            }
            catch (ArgumentException ae)
            {
                return Forbid(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(PostDeleteViewModel model)
        {
            string userId = User.GetId()!;

            bool hasAccess = await this.moderatorService.IsModeratorAsync(userId, model.CommunityId) ||
                    await this.communityService.IsUserOwnerAsync(model.CommunityId, userId) ||
                     await this.postService.IsUserCreatorAsync(model.Id, userId);

            if (!hasAccess)
            {
                //TempData
                throw new InvalidOperationException("User is not the creator of the post!");
            }

            try
            {
                await this.postService.DeleteAsync(model);

                return RedirectToAction("Feed", "Community", new { id = model.CommunityId });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Like(string id, string userId)
        {
            try
            {
                Tuple<int, int> tuple;

                if (await this.postService.HasUserInteractedAsync(id, userId))
                {
                    if (await this.postService.HasLikedAsync(id, userId))
                    {
                        tuple = await this.postService.UnlikeAsync(id, userId);
                    }
                    else
                    {
                        tuple = await this.postService.ChangeDislikeToLikeAsync(id, userId);
                    }
                }
                else
                {
                    int likes = await this.postService.LikeAsync(id, userId);

                    tuple = new Tuple<int, int>(likes, 0);
                }

                return Json(new { likes = tuple.Item1, dislikes = tuple.Item2 });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Dislike(string id, string userId)
        {
            try
            {
                Tuple<int, int> tuple;

                if (await this.postService.HasUserInteractedAsync(id, userId))
                {
                    if (await this.postService.HasDislikedAsync(id, userId))
                    {
                        tuple = await this.postService.UndislikeAsync(id, userId);
                    }
                    else
                    {
                        tuple = await this.postService.ChangeLikeToDislikeAsync(id, userId);
                    }
                }
                else
                {
                    int dislikes = await this.postService.DislikeAsync(id, userId);

                    tuple = new Tuple<int, int>(0, dislikes);
                }

                return Json(new { likes = tuple.Item1, dislikes = tuple.Item2 });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

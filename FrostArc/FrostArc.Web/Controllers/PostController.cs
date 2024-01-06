namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.Infrastructire.Extensions;

    [Authorize]
    public class PostController : Controller
    {
        private IPostService postService;

        public PostController(IPostService postService)
        {
            this.postService = postService;
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

        [HttpPost]
        public async Task<IActionResult> Like(string id, string userId)
        {
            try
            {
                int updatedLikes;
                bool hasUserLiked = await this.postService.HasUserLikedAsync(id, userId);

                if (hasUserLiked)
                {
                    updatedLikes = await this.postService.UnlikeAsync(id, userId);
                }
                else
                {
                    updatedLikes = await this.postService.LikeAsync(id, userId);
                }

                return Json(new { likes = updatedLikes });
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
                int updatedDislikes = await this.postService.DislikeAsync(id, userId);

                return Json(new { dislikes = updatedDislikes });
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

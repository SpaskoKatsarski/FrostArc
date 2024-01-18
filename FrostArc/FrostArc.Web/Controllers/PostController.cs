namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Web.ViewModels.Post;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.Infrastructire.Extensions;
    using FrostArc.Data.Models;

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

        [HttpGet]
        public async Task<IActionResult> Edit(string postId)
        {
            try
            {
                PostFormViewModel post = await this.postService.GetForEditAsync(postId);

                return View(post);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(PostFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
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

        [HttpPost]
        public async Task<IActionResult> Like(string id, string userId)
        {
            try
            {
                int updatedLikes;

                if (await this.postService.HasUserInteractedAsync(id, userId))
                {
                    if (await this.postService.HasLikedAsync(id, userId))
                    {
                        updatedLikes = await this.postService.UnlikeAsync(id, userId);
                    }
                    else
                    {
                        Tuple<int, int> tuple = await this.postService.ChangeDislikeToLikeAsync(id, userId);

                        return Json(new { likes = tuple.Item1, dislikes = tuple.Item2 });
                    }
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

        [HttpPost]
        public async Task<IActionResult> Comment(string postId, string userId, string content)
        {
            try
            {
                Comment comment = await this.postService.AddCommentAsync(postId, userId, content);

                return Json(new { newComment = comment.Content, newCommentUserId = comment.UserId.ToString() });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }
    }
}

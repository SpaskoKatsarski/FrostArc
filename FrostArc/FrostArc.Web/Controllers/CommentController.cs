namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Web.ViewModels.Comment;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.Infrastructire.Extensions;

    [Authorize]
    public class CommentController : Controller
    {
        private ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Comment([FromBody] CommentInputViewModel inputModel)
        {
            try
            {
                Tuple<string, string, bool> triple = await this.commentService.AddCommentAsync(inputModel);

                return Json(new { newComment = triple.Item1, newCommentUser = triple.Item2, isOwner = triple.Item3 });
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id, string userId, bool isUserOwnerOrMod)
        {
            try
            {
                bool isUserCreator = await this.commentService.IsUserCreatorOfCommentAsync(userId, id);

                if (!isUserCreator && !isUserOwnerOrMod)
                {
                    //TempData[ErrorMessage] = "";
                    throw new InvalidOperationException("User is not creator of the comment!");
                }

                CommentEditViewModel model = await this.commentService.GetForEditAsync(id, userId, isUserOwnerOrMod);

                return View(model);
            }
            catch (InvalidOperationException ioe)
            {
                return Forbid(ioe.Message);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CommentEditViewModel model)
        {
            try
            {
                string userId = this.User.GetId()!;

                if (!model.HasAccess)
                {
                    throw new InvalidOperationException("User cannot modify the comment!");
                }

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                await this.commentService.EditAsync(model);

                string communityId = await this.commentService.GetCommunityIdByCommentAsync(model.Id);
                return RedirectToAction("Feed", "Community", new { id = communityId });
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

        [HttpGet]
        public async Task<IActionResult> Delete(string id, string userId, bool isUserOwnerOrMod)
        {
            try
            {
                bool isUserCreator = await this.commentService.IsUserCreatorOfCommentAsync(userId, id);

                if (!isUserCreator && !isUserOwnerOrMod)
                {
                    //TempData[ErrorMessage] = "";
                    throw new InvalidOperationException("User is not creator of the comment!");
                }

                CommentDeleteViewModel model = await this.commentService.GetForDeleteAsync(id, userId, isUserOwnerOrMod);

                return View(model);
            }
            catch (ArgumentException ae)
            {
                return BadRequest(ae.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(CommentDeleteViewModel model)
        {
            try
            {
                string userId = this.User.GetId()!;

                if (!model.HasAccess)
                {
                    //TempData[ErrorMessage] = "";
                    throw new InvalidOperationException("User is not creator of the comment!");
                }

                string communityId = await this.commentService.GetCommunityIdByCommentAsync(model.Id);
                await this.commentService.RemoveAsync(model);

                return RedirectToAction("Feed", "Community", new { id = communityId });
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
    }
}

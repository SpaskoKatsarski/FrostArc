namespace FrostArc.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using FrostArc.Web.ViewModels.Comment;
    using FrostArc.Services.Contracts;

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
        public async Task<IActionResult> Edit(string id, string userId)
        {
            try
            {
                if (await this.commentService.IsUserCreatorOfCommentAsync(userId, id))
                {
                    throw new InvalidOperationException("User is not creator of the comment!");
                }

                CommentFormViewModel model = await this.commentService.GetForEditAsync(id);

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
    }
}

namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Comment;

    public interface ICommentService
    {
        Task<Tuple<string, string, bool>> AddCommentAsync(CommentInputViewModel inputModel);

        Task<CommentFormViewModel> GetForEditAsync(string id);

        Task<bool> IsUserCreatorOfCommentAsync(string userId, string commendId);
    }
}

﻿namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Comment;

    public interface ICommentService
    {
        Task<Tuple<string, string, bool>> AddCommentAsync(CommentInputViewModel inputModel);

        Task<CommentEditViewModel> GetForEditAsync(string id);

        Task<CommentDeleteViewModel> GetForDeleteAsync(string id);

        Task<bool> IsUserCreatorOfCommentAsync(string userId, string commendId);

        Task EditAsync(CommentEditViewModel model);

        Task<string> GetCommunityIdByCommentAsync(string commentId);
        Task RemoveAsync(CommentDeleteViewModel model);
    }
}

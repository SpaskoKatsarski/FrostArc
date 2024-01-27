namespace FrostArc.Services.Contracts
{
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Comment;
    using FrostArc.Web.ViewModels.Post;

    public interface IPostService
    {
        Task<Post> CreateAsync(PostFormViewModel model);

        Task<IEnumerable<PostAllViewModel>> GetAllForUserAsync(string userId);

        Task<int> LikeAsync(string id, string userId);

        Task<int> DislikeAsync(string id, string userId);

        Task<bool> HasUserInteractedAsync(string id, string userId);

        Task<Tuple<int, int>> UnlikeAsync(string id, string userId);

        Task<Tuple<int, int>> ChangeDislikeToLikeAsync(string id, string userId);

        Task<Tuple<int, int>> UndislikeAsync(string id, string userId);

        Task<Tuple<int, int>> ChangeLikeToDislikeAsync(string id, string userId);

        Task<bool> HasLikedAsync(string id, string userId);

        Task<bool> HasDislikedAsync(string id, string userId);

        Task<Comment> AddCommentAsync(CommentInputViewModel inputModel);

        Task EditAsync(PostFormViewModel model);

        Task<PostFormViewModel> GetForEditAsync(string postId);

        Task<bool> IsUserCreatorAsync(string postId, string userId);

        Task<PostDeleteViewModel> GetForDeleteAsync(string postId);

        Task DeleteAsync(PostDeleteViewModel model);
    }
}

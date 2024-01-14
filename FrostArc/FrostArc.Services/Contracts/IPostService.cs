namespace FrostArc.Services.Contracts
{
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Post;

    public interface IPostService
    {
        Task<Post> CreateAsync(PostFormViewModel model);

        Task<IEnumerable<PostAllViewModel>> GetAllForUserAsync(string userId);

        Task<int> LikeAsync(string id, string userId);

        Task<int> DislikeAsync(string id, string userId);

        Task<bool> HasUserInteractedAsync(string id, string userId);

        Task<int> UnlikeAsync(string id, string userId);

        Task<Tuple<int, int>> ChangeDislikeToLikeAsync(string id, string userId);

        Task<bool> HasLikedAsync(string id, string userId);

        Task<Comment> AddCommentAsync(string postId, string userId, string comment);
    }
}

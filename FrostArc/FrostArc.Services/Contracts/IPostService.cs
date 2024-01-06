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

        Task<bool> HasUserLikedAsync(string id, string userId);

        Task<int> UnlikeAsync(string id, string userId);
    }
}

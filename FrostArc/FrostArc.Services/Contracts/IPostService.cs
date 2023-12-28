namespace FrostArc.Services.Contracts
{
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Post;

    public interface IPostService
    {
        Task<Post> CreateAsync(PostFormViewModel model);

        Task<IEnumerable<PostAllViewModel>> GetAllForUserAsync(string userId);

        Task<int> LikeAsync(string id);

        Task<int> DislikeAsync(string id);
    }
}

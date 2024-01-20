namespace FrostArc.Services.Contracts
{
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Community;
    using FrostArc.Web.ViewModels.Post;

    public interface ICommunityService
    {
        Task<IEnumerable<CommunityAllViewModel>> GetAllAsync(string? queryStr);

        Task<Community> CreateAsync(CommunityFormViewModel model, string ownerId);

        Task UpdateCommunityAsync(CommunityFormViewModel updateModel);

        Task DeleteCommunityAsync(string communityId);

        Task<Community> FindAsync(string communityId);

        Task<IEnumerable<CommunityAllViewModel>> SearchAsync(string queryStr);

        Task<CommunityUsersViewModel> GetCommunityUsersAsync(string communityId);

        Task<int> GetMembersCountAsync(string communityId);

        Task AddUserToCommunityAsync(string communityId, string userId);

        Task<IEnumerable<CommunityAllViewModel>> GetCommunitiesForUserAsync(string userId);

        Task<IEnumerable<CommunityAllViewModel>> GetTop3Async();

        Task<CommunityDetailsViewModel> GetForDetailsAsync(string id);

        Task<CommunityFeedViewModel> GetForFeedAsync(string id);

        Task<bool> IsUserOwnerAsync(string communityId, string userId);

        Task<bool> IsUserMemberAsync(string communityId, string userId);

        Task RemoveUserFromCommunityAsync(string communityId, string userId);

        Task RemovePostsForUserAsync(string communityId, string userId);

        Task<IEnumerable<PostAllViewModel>> GetPostsForCommunityAsync(string communityId);
    }
}

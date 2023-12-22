namespace FrostArc.Services.Contracts
{
    using FrostArc.Data.Models;
    using FrostArc.Web.ViewModels.Community;

    public interface ICommunityService
    {
        Task<IEnumerable<CommunityAllViewModel>> GetAllAsync();

        Task CreateAsync(CommunityFormViewModel model);

        Task UpdateCommunityAsync(CommunityFormViewModel updateModel);

        Task DeleteCommunityAsync(string communityId);

        Task<Community> FindAsync(string communityId);

        Task<IEnumerable<CommunityAllViewModel>> SearchAsync(string queryStr);

        Task<int> GetMembersCountAsync(string communityId);

        Task AddUserToCommunityAsync(string communityId, string userId);

        Task<IEnumerable<CommunityAllViewModel>> GetCommunitiesForUserAsync(string userId);

        Task<IEnumerable<CommunityAllViewModel>> GetTop3Async();

        Task<CommunityDetailsViewModel> GetForDetailsAsync(string id);
    }
}

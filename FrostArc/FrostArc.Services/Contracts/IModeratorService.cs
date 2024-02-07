namespace FrostArc.Services.Contracts
{
    public interface IModeratorService
    {
        Task PromoteAsync(string userId, string communityId);

        Task<bool> IsModeratorAsync(string userId, string communityId);

        Task DemoteAsync(string userId, string communityId);
    }
}

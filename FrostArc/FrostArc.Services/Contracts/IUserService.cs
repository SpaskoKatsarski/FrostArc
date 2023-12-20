namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.User;

    public interface IUserService
    {
        Task<string> GetDisplayNameAsync(string userId);

        Task<UserDetailsViewModel> GetInfoAsync(string userId);

        Task<string> GetUserImageUrlAsync(string userId);

        Task UpdateAvatarAsync(string userId, string imageUrl);
    }
}

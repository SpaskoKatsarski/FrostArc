namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Platform;

    public interface IPlatformService
    {
        Task<IEnumerable<PlatformAllViewModel>> GetAllAsync();

        Task<PlatformDetailsViewModel> GetDetailsAsync(int platformId);
    }
}

namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Developer;

    public interface IDeveloperService
    {
        Task<IEnumerable<DeveloperAllViewModel>> GetAllAsync();

        Task<DeveloperDetailsViewModel> GetDetailsAsync(string id);
    }
}

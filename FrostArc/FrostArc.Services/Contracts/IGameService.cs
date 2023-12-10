namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Game;

    public interface IGameService
    {
        Task<IEnumerable<GameAllViewModel>> GetAllAsync();

        Task<GameDetailsViewModel> GetDetailsAsync(string id);
    }
}

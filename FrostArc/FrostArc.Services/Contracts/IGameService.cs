namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Game;

    public interface IGameService
    {
        Task<IEnumerable<GameListViewModel>> GetAllAsync();

        Task<GameDetailsViewModel> GetDetailsAsync(string id);
    }
}

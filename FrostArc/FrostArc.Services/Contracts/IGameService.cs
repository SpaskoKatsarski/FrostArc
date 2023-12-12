namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Game;

    public interface IGameService
    {
        Task<IEnumerable<GameListViewModel>> GetAllAsync(string? genreId);

        Task<GameDetailsViewModel> GetDetailsAsync(string id);
    }
}

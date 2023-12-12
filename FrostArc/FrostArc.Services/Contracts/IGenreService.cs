namespace FrostArc.Services.Contracts
{
    using FrostArc.Web.ViewModels.Genre;

    public interface IGenreService
    {
        Task<IEnumerable<GenreAllViewModel>> GetAllAsync();
    }
}

namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Data.Models;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Game;

    public class GameService : IGameService
    {
        private FrostArcDbContext dbContext;

        public GameService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<GameListViewModel>> GetAllAsync(string? genreId)
        {
            IQueryable<Game> query = this.dbContext.Games
                .AsNoTracking()
                .Where(g => !g.IsDeleted);
        
            if (genreId != null)
            {
                query = query.Where(g => g.GenreId.ToString() == genreId);
            }

            return await query.Select(g => new GameListViewModel()
            {
                Id = g.Id.ToString(),
                Title = g.Title,
                ImageUrl = g.ImageUrl
            }).ToListAsync();
        }

        public async Task<GameDetailsViewModel> GetDetailsAsync(string id)
        {
            Game? game = await this.dbContext.Games
                .Include(g => g.Developer)
                .Include(g => g.Genre)
                .Include(g => g.GamePlatforms)
                .ThenInclude(gp => gp.Platform)
                .Where(g => !g.IsDeleted)
                .FirstOrDefaultAsync(g => g.Id.ToString() == id);

            if (game == null)
            {
                throw new ArgumentException("Game does not exist in the library!");
            }

            return new GameDetailsViewModel()
            {
                Id = game.Id.ToString(),
                Title = game.Title,
                Description = game.Description,
                ImageUrl = game.ImageUrl,
                Developer = game.Developer.Name,
                DeveloperId = game.DeveloperId.ToString(),
                Genre = game.Genre.Name,
                Platforms = game.GamePlatforms.Select(gp => gp.Platform.Name)
            };
        }
    }
}

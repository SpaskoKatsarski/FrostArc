namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Web.ViewModels.Genre;
    using FrostArc.Services.Contracts;
    using FrostArc.Data;

    public class GenreService : IGenreService
    {
        private FrostArcDbContext dbContext;

        public GenreService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<GenreAllViewModel>> GetAllAsync()
        {
            return await this.dbContext.Genres
                .Select(g => new GenreAllViewModel()
                {
                    Id = g.Id.ToString(),
                    Name = g.Name,
                    Description = g.Description
                }).ToListAsync();
        }
    }
}

namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Web.ViewModels.Genre;
    using FrostArc.Services.Contracts;
    using FrostArc.Data;
    using FrostArc.Data.Models;

    public class GenreService : IGenreService
    {
        private FrostArcDbContext dbContext;

        public GenreService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<GenreAllViewModel>> GetAllAsync(string? queryStr)
        {
            IQueryable<Genre> query = this.dbContext.Genres
                .AsNoTracking()
                .Where(g => !g.IsDeleted);

            if (queryStr != null)
            {
                query = query.Where(g => g.Name.ToLower().Contains(queryStr.ToLower()));
            }

            return await query
                .Select(g => new GenreAllViewModel()
                {
                    Id = g.Id.ToString(),
                    Name = g.Name,
                    Description = g.Description
                }).ToListAsync();
        }
    }
}

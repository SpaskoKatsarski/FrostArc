namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Platform;
    using FrostArc.Web.ViewModels.Game;
    using FrostArc.Data.Models;

    public class PlatformService : IPlatformService
    {
        private FrostArcDbContext dbContext;

        public PlatformService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<PlatformAllViewModel>> GetAllAsync()
        {
            return await this.dbContext.Platforms
                .Select(p => new PlatformAllViewModel()
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToListAsync();
        }

        public async Task<PlatformDetailsViewModel> GetDetailsAsync(int platformId)
        {
            Platform? platform = await this.dbContext.Platforms
                .FirstOrDefaultAsync(p => p.Id == platformId);

            if (platform == null)
            {
                throw new ArgumentException("Platform with the provided ID does not exist!");
            }

            return new PlatformDetailsViewModel()
            {
                Id = platform.Id,
                Name = platform.Name,
                Description = platform.Description,
                Games = platform.Games
                    .Select(g => new GameListViewModel()
                    {
                        Id = g.Id.ToString(),
                        Title = g.Title,
                        ImageUrl = g.ImageUrl
                    })
            };
        }
    }
}

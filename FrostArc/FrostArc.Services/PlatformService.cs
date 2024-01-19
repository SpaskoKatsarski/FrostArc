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
                .Where(p => !p.IsDeleted)
                .Select(p => new PlatformAllViewModel()
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToListAsync();
        }

        public async Task<PlatformDetailsViewModel> GetDetailsAsync(int platformId)
        {
            Platform? platform = await this.dbContext.Platforms
                .Include(p => p.GamePlatforms)
                .ThenInclude(gp => gp.Game)
                .Where(p => !p.IsDeleted)
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
                Games = platform.GamePlatforms
                    .Select(gp => new GameListViewModel()
                    {
                        Id = gp.Game.Id.ToString(),
                        Title = gp.Game.Title,
                        ImageUrl = gp.Game.ImageUrl
                    })
            };
        }
    }
}

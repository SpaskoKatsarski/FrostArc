﻿namespace FrostArc.Services
{
    using Microsoft.EntityFrameworkCore;

    using FrostArc.Data;
    using FrostArc.Services.Contracts;
    using FrostArc.Web.ViewModels.Developer;
    using FrostArc.Web.ViewModels.Game;
    using FrostArc.Data.Models;

    public class DeveloperService : IDeveloperService
    {
        private FrostArcDbContext dbContext;

        public DeveloperService(FrostArcDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<DeveloperAllViewModel>> GetAllAsync(string? queryStr)
        {
            IQueryable<Developer> query = this.dbContext.Developers
                .AsNoTracking()
                .Where(d => !d.IsDeleted);

            if (queryStr != null)
            {
                query = query.Where(d => d.Name.ToLower().Contains(queryStr.ToLower()));
            }

            return await query
                .Select(d => new DeveloperAllViewModel()
                {
                    Id = d.Id.ToString(),
                    Name = d.Name,
                    ImageUrl = d.ImageUrl
                })
                .ToListAsync();
        }

        public async Task<DeveloperDetailsViewModel> GetDetailsAsync(string id)
        {
            Developer? dev = await this.dbContext.Developers
                .Include(d => d.Games)
                .Where(c => !c.IsDeleted)
                .FirstOrDefaultAsync(d => d.Id.ToString() == id);

            if (dev == null)
            {
                throw new ArgumentException("Developer with the provided ID does not exist!");
            }

            return new DeveloperDetailsViewModel()
            {
                Id = dev.Id.ToString(),
                Name = dev.Name,
                Description = dev.Description,
                ImageUrl = dev.ImageUrl,
                Games = dev.Games
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

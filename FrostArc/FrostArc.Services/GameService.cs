﻿namespace FrostArc.Services
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

        public async Task<IEnumerable<GameAllViewModel>> GetAllAsync()
        {
            return await this.dbContext.Games
                .AsNoTracking()
                .Select(g => new GameAllViewModel()
                {
                    Id = g.Id.ToString(),
                    Title = g.Title,
                    ImageUrl = g.ImageUrl
                })
                .ToListAsync();

        }

        public async Task<GameDetailsViewModel> GetDetailsAsync(string id)
        {
            Game? game = await this.dbContext.Games
                .Include(g => g.Developer)
                .Include(g => g.Genre)
                .Include(g => g.Platforms)
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
                Genre = game.Genre.Name,
                Platforms = game.Platforms.Select(p => p.Name)
            };
        }
    }
}
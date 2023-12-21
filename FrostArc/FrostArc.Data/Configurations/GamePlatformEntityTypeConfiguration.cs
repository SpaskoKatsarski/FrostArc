namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class GamePlatformEntityTypeConfiguration : IEntityTypeConfiguration<GamePlatform>
    {
        public void Configure(EntityTypeBuilder<GamePlatform> builder)
        {
            builder.HasKey(gp => new { gp.GameId, gp.PlatformId });

            builder.HasData(this.SeedEntities());
        }

        private ICollection<GamePlatform> SeedEntities()
        {
            return new List<GamePlatform>()
            {
                // The Witcher 3: Wild Hunt
                new GamePlatform { GameId = new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), PlatformId = 3 },

                // Call of Duty: Modern Warfare
                new GamePlatform { GameId = new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), PlatformId = 3 },

                // League of Legends
                new GamePlatform { GameId = new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"), PlatformId = 1 },

                // The Elder Scrolls V: Skyrim
                new GamePlatform { GameId = new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), PlatformId = 3 },

                // Dark Souls III
                new GamePlatform { GameId = new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), PlatformId = 3 },

                // Assassin's Creed Odyssey
                new GamePlatform { GameId = new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), PlatformId = 3 },

                // Dota 2
                new GamePlatform { GameId = new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"), PlatformId = 1 },

                // Final Fantasy XV
                new GamePlatform { GameId = new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), PlatformId = 3 },

                // Overwatch
                new GamePlatform { GameId = new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), PlatformId = 3 },

                // Grand Theft Auto V
                new GamePlatform { GameId = new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), PlatformId = 1 },
                new GamePlatform { GameId = new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), PlatformId = 2 },
                new GamePlatform { GameId = new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), PlatformId = 3 },
            };
        }
    }
}

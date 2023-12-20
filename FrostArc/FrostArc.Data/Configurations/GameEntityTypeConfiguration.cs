namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class GameEntityTypeConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasOne(g => g.Developer)
                .WithMany(d => d.Games)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(g => g.Genre)
                .WithMany(g => g.Games)
                .OnDelete(DeleteBehavior.NoAction);
        }

        private IEnumerable<Game> SeedGames()
        {
            var games = new List<Game>()
            {
                new Game()
                {
                    Title = "The Witcher 3: Wild Hunt",
                    Description = "An open-world RPG set in a gritty fantasy universe.",
                    ReleaseDate = new DateTime(2015, 5, 19),
                    DeveloperId = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    GenreId = 3,
                    ImageUrl = "https://example.com/witcher3_image.png",
                    Platforms = new HashSet<Platform>{ /* PC, PS, Xbox */ }
                },
                new Game()
                {
                    Title = "Call of Duty: Modern Warfare",
                    Description = "A first-person shooter with intense campaigns and multiplayer modes.",
                    ReleaseDate = new DateTime(2019, 10, 25),
                    DeveloperId = new Guid("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                    GenreId = 9,
                    ImageUrl = "https://example.com/cod_mw_image.png",
                    Platforms = new HashSet<Platform>{ /* PC, PS, Xbox */ }
                },
                new Game()
                {
                    Title = "League of Legends",
                    Description = "A highly popular multiplayer online battle arena game.",
                    ReleaseDate = new DateTime(2009, 10, 27),
                    DeveloperId = new Guid("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                    GenreId = 11,
                    ImageUrl = "https://example.com/lol_image.png",
                    Platforms = new HashSet<Platform>{ /* PC Platform ID */ }
                },
                new Game()
                {
                    Title = "The Elder Scrolls V: Skyrim",
                    Description = "An open-world action RPG set in a detailed fantasy world.",
                    ReleaseDate = new DateTime(2011, 11, 11),
                    DeveloperId = new Guid("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                    GenreId = 3,
                    ImageUrl = "https://example.com/skyrim_image.png",
                    Platforms = new HashSet<Platform>{ /* Multiple Platform IDs */ }
                },
                new Game()
                {
                    Title = "Dark Souls III",
                    Description = "A challenging and intricate action RPG known for its difficulty.",
                    ReleaseDate = new DateTime(2016, 3, 24),
                    DeveloperId = new Guid("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                    GenreId = 3,
                    ImageUrl = "https://example.com/darksouls3_image.png",
                    Platforms = new HashSet<Platform>{ /* Multiple Platform IDs */ }
                },
                new Game()
                {
                    Title = "Assassin's Creed Odyssey",
                    Description = "An action RPG set in ancient Greece, part of the Assassin's Creed series.",
                    ReleaseDate = new DateTime(2018, 10, 5),
                    DeveloperId = new Guid("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"),
                    GenreId = 3,
                    ImageUrl = "https://example.com/ac_odyssey_image.png",
                    Platforms = new HashSet<Platform>{ /* IDs for PC, PlayStation, Xbox */ }
                },
                new Game()
                {
                    Title = "Dota 2",
                    Description = "A popular MOBA game known for its strategic depth and complexity.",
                    ReleaseDate = new DateTime(2013, 7, 9),
                    DeveloperId = new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                    GenreId = 11,
                    ImageUrl = "https://example.com/dota2_image.png",
                    Platforms = new HashSet<Platform>{ /* PC Platform ID */ }
                },
                new Game()
                {
                    Title = "Final Fantasy XV",
                    Description = "A fantasy RPG with an emphasis on fast-paced action and character-driven storytelling.",
                    ReleaseDate = new DateTime(2016, 11, 29),
                    DeveloperId = new Guid("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                    GenreId = 3,
                    ImageUrl = "https://example.com/ffxv_image.png",
                    Platforms = new HashSet<Platform>{ /* IDs for PC, PlayStation, Xbox */ }
                },
                new Game()
                {
                    Title = "Overwatch",
                    Description = "A team-based multiplayer first-person shooter with a wide range of unique heroes.",
                    ReleaseDate = new DateTime(2016, 5, 24),
                    DeveloperId = new Guid("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"), 
                    GenreId = 9, 
                    ImageUrl = "https://example.com/overwatch_image.png",
                    Platforms = new HashSet<Platform>{ /* IDs for PC, PlayStation, Xbox */ }
                },
                new Game()
                {
                    Title = "Grand Theft Auto V",
                    Description = "An action-adventure game set in a fictional state, featuring an open world and a story-driven campaign.",
                    ReleaseDate = new DateTime(2013, 9, 17),
                    DeveloperId = new Guid("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                    GenreId = 2,
                    ImageUrl = "https://example.com/gtav_image.png",
                    Platforms = new HashSet<Platform>{ /* IDs for PC, PlayStation, Xbox */ }
                }
            };

            return games;
        }
    }
}

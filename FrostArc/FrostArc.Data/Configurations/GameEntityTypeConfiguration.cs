﻿namespace FrostArc.Data.Configurations
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

            builder.HasData(this.SeedGames());
        }

        private IEnumerable<Game> SeedGames()
        {
            ICollection<Game> games = new List<Game>()
            {
                new Game()
                {
                    Id = new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"),
                    Title = "The Witcher 3: Wild Hunt",
                    Description = "An open-world RPG set in a gritty fantasy universe.",
                    ReleaseDate = new DateTime(2015, 5, 19),
                    DeveloperId = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    GenreId = 3,
                    ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png"
                },
                new Game()
                {
                    Id = new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"),
                    Title = "Call of Duty: Modern Warfare",
                    Description = "A first-person shooter with intense campaigns and multiplayer modes.",
                    ReleaseDate = new DateTime(2019, 10, 25),
                    DeveloperId = new Guid("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                    GenreId = 9,
                    ImageUrl = "https://image.api.playstation.com/cdn/EP0002/CUSA05379_00/iTxbX14rj7Qhk3zYc6bnmDiuXMIK2UUW.png"
                },
                new Game()
                {
                    Id = new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"),
                    Title = "League of Legends",
                    Description = "A highly popular multiplayer online battle arena game.",
                    ReleaseDate = new DateTime(2009, 10, 27),
                    DeveloperId = new Guid("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                    GenreId = 11,
                    ImageUrl = "https://stryda.gg/_next/image?url=https%3A%2F%2Fwww.datocms-assets.com%2F92583%2F1675777489-league-of-legends-cover.webp&w=1280&q=75"
                },
                new Game()
                {
                    Id = new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"),
                    Title = "The Elder Scrolls V: Skyrim",
                    Description = "An open-world action RPG set in a detailed fantasy world.",
                    ReleaseDate = new DateTime(2011, 11, 11),
                    DeveloperId = new Guid("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                    GenreId = 3,
                    ImageUrl = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w.jpg"
                },
                new Game()
                {
                    Id = new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"),
                    Title = "Dark Souls III",
                    Description = "A challenging and intricate action RPG known for its difficulty.",
                    ReleaseDate = new DateTime(2016, 3, 24),
                    DeveloperId = new Guid("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                    GenreId = 3,
                    ImageUrl = "https://image.api.playstation.com/cdn/EP0700/CUSA03365_00/OFMeAw2KhrdaEZAjW1f3tCIXbogkLpTC.png"
                },
                new Game()
                {
                    Id = new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"),
                    Title = "Assassin's Creed Odyssey",
                    Description = "An action RPG set in ancient Greece, part of the Assassin's Creed series.",
                    ReleaseDate = new DateTime(2018, 10, 5),
                    DeveloperId = new Guid("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"),
                    GenreId = 3,
                    ImageUrl = "https://image.api.playstation.com/cdn/EP0001/CUSA09303_00/tzKcptCCUkiigpacybO8xWmvxPS7vIzk.png"
                },
                new Game()
                {
                    Id = new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"),
                    Title = "Dota 2",
                    Description = "A popular MOBA game known for its strategic depth and complexity.",
                    ReleaseDate = new DateTime(2013, 7, 9),
                    DeveloperId = new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                    GenreId = 11,
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg"
                },
                new Game()
                {
                    Id = new Guid("56b33636-b50f-4c0f-940a-8f361428b330"),
                    Title = "Final Fantasy XV",
                    Description = "A fantasy RPG with an emphasis on fast-paced action and character-driven storytelling.",
                    ReleaseDate = new DateTime(2016, 11, 29),
                    DeveloperId = new Guid("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                    GenreId = 3,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5a/FF_XV_cover_art.jpg"
                },
                new Game()
                {
                    Id = new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"),
                    Title = "Overwatch",
                    Description = "A team-based multiplayer first-person shooter with a wide range of unique heroes.",
                    ReleaseDate = new DateTime(2016, 5, 24),
                    DeveloperId = new Guid("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"),
                    GenreId = 9,
                    ImageUrl = "https://blz-contentstack-images.akamaized.net/v3/assets/blt2477dcaf4ebd440c/bltdabc3782553659f1/650cc84db1e5551677dcd71d/ow2_xboxshowcase_static_7.png?format=webply&quality=90"
                },
                new Game()
                {
                    Id = new Guid("94640685-0e93-47aa-81aa-ff19991dc088"),
                    Title = "Grand Theft Auto V",
                    Description = "An action-adventure game set in a fictional state, featuring an open world and a story-driven campaign.",
                    ReleaseDate = new DateTime(2013, 9, 17),
                    DeveloperId = new Guid("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                    GenreId = 2,
                    ImageUrl = "https://cdn.akamai.steamstatic.com/steam/apps/271590/capsule_616x353.jpg?t=1695060909"
                }
            };

            return games;
        }
    }
}

namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class DeveloperEntityTypeConfiguration : IEntityTypeConfiguration<Developer>
    {
        public void Configure(EntityTypeBuilder<Developer> builder)
        {
            builder.HasData(this.SeedDevelopers());
        }

        private IEnumerable<Developer> SeedDevelopers()
        {
            ICollection<Developer> developers = new List<Developer>()
            {
                new Developer
                {
                    Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    Name = "CD Projekt Red",
                    Description = "Polish video game developer known for The Witcher series.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/CD_Projekt_logo.svg/1200px-CD_Projekt_logo.svg.png"
                },
                new Developer
                {
                    Id = new Guid("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                    Name = "Infinity Ward",
                    Description = "American video game developer, creator of the Call of Duty series.",
                    ImageUrl = "https://static.wikia.nocookie.net/cod_esports_gamepedia_en/images/d/d7/Infinty_Ward_logo.png/revision/latest?cb=20200707211638"
                },
                new Developer
                {
                     Id = new Guid("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                    Name = "Riot Games",
                    Description = "American video game developer known for League of Legends.",
                    ImageUrl = "https://www.riotgames.com/darkroom/800/87521fcaeca5867538ae7f46ac152740:2f8144e17957078916e41d2410c111c3/002-rg-2021-full-lockup-offwhite.jpg"
                },
                new Developer
                {
                    Id = new Guid("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                    Name = "Bethesda Game Studios",
                    Description = "American video game developer, famous for the Elder Scrolls series.",
                    ImageUrl = "https://images.ctfassets.net/rporu91m20dc/4gNvwblcIUQMAa0QWakgAk/64625a987bad1812862748367703938b/BGS_LargeHero_Future.jpg"
                },
                new Developer
                {
                     Id = new Guid("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                    Name = "FromSoftware",
                    Description = "Japanese video game development company, renowned for the Dark Souls series.",
                    ImageUrl = "https://static.wikia.nocookie.net/sony-playstation/images/f/fe/FromSoftware_logo_black_background.png/revision/latest?cb=20220901192200"
                },
                new Developer
                {
                    Id = new Guid("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"),
                    Name = "Ubisoft",
                    Description = "French video game company, known for creating the Assassin's Creed series.",
                    ImageUrl = "https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/3h4s0GE47IBDxheVyJkfuX/e854163c0246c91bd79f390e9414391e/ubisoft_logo_whiteonblack_960x540_351175.jpg"
                },
                new Developer
                {
                    Id = new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                    Name = "Valve Corporation",
                    Description = "American video game developer, publisher and digital distribution company, known for Dota 2.",
                    ImageUrl = "https://pbs.twimg.com/profile_images/1196563043150204928/X6pfa2YZ_400x400.jpg"
                },
                new Developer
                {
                    Id = new Guid("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                    Name = "Square Enix",
                    Description = "Japanese video game developer, publisher, and distribution company, famous for the Final Fantasy series.",
                    ImageUrl = "https://www.hd.square-enix.com/eng/assets/img/og/ogp_square-enix.png"
                },
                new Developer
                {
                    Id = new Guid("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"),
                    Name = "Blizzard Entertainment",
                    Description = "American video game developer and publisher, known for Overwatch.",
                    ImageUrl = "https://blz-contentstack-images.akamaized.net/v3/assets/blta8f9a8e092360c6c/bltbe1a42777abcc0da/620d1898a38b0106946f17d2/thumbnail-home.jpg"
                },
                new Developer
                {
                    Id = new Guid("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                    Name = "Rockstar Games",
                    Description = "American video game publisher, famous for the Grand Theft Auto series.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/1200px-Rockstar_Games_Logo.svg.png"
                }
            };

            return developers;
        }
    }
}

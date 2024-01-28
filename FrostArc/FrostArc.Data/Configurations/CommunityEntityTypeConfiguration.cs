namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;
    using static FrostArc.Common.GeneralApplicationConstants.DefaultUser;

    public class CommunityEntityTypeConfiguration : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder
                .HasOne(c => c.Owner)
                .WithMany(u => u.OwnedCommunities)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(this.SeedCommunities());
        }

        public IEnumerable<Community> SeedCommunities()
        {
            ICollection<Community> communities = new List<Community>()
            {
                new Community()
                {
                    Id = new Guid("f37eedfe-96ed-4448-a0de-48392e7ae50d"),
                    Name = "Diablo 3",
                    Description = "A community for Diablo 3 enthusiasts.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("a10c0f03-7cf2-4128-b74a-5f324d8d1027"),
                    Name = "The Witcher Series",
                    Description = "A community for fans of The Witcher series.",
                    ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("73a36f6e-9f3d-420b-bcb6-63c3980d9e98"),
                    Name = "Call of Duty",
                    Description = "A gathering spot for Call of Duty players.",
                    ImageUrl = "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("1177b3c1-0f40-471a-99fa-6f00fef2e672"),
                    Name = "League of Legends",
                    Description = "Community for League of Legends players and enthusiasts.",
                    ImageUrl = "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("c52fa30e-027a-471f-9839-a8fdea12562c"),
                    Name = "Elder Scrolls",
                    Description = "For fans of the Elder Scrolls series.",
                    ImageUrl = "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("9a7fba4c-ff70-4f3f-a17e-d6369cbf1974"),
                    Name = "Dark Souls",
                    Description = "A community dedicated to the challenging world of Dark Souls.",
                    ImageUrl = "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("4c770262-3889-4ef3-9899-c1d97f3ae8dc"),
                    Name = "Assassin's Creed",
                    Description = "Fans of the Assassin's Creed series unite here.",
                    ImageUrl = "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("a7eb244f-6e4a-45b6-9b6f-6b16feda05d9"),
                    Name = "Dota 2",
                    Description = "A hub for Dota 2 players of all levels.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("5d10d6d7-6223-482a-a98c-2ab4a3c4cfe2"),
                    Name = "Final Fantasy",
                    Description = "A community for lovers of the Final Fantasy series.",
                    ImageUrl = "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("5ad3fedc-4a19-4915-b59d-f7d385277d06"),
                    Name = "Overwatch",
                    Description = "A place for Overwatch players and fans.",
                    ImageUrl = "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg",
                    OwnerId = new Guid(Id)
                },
                new Community()
                {
                    Id = new Guid("6cde4016-6159-4ff9-8581-b0de4e1a7dc5"),
                    Name = "Grand Theft Auto",
                    Description = "Community for enthusiasts of the Grand Theft Auto series.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png",
                    OwnerId = new Guid(Id)
                }
            };

            return communities;
        }
    }
}

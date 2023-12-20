namespace FrostArc.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using FrostArc.Data.Models;

    public class CommunityEntityTypeConfiguration : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder.HasData(this.SeedCommunities());
        }

        public IEnumerable<Community> SeedCommunities()
        {
            ICollection<Community> communities = new List<Community>()
            {
                new Community()
                {
                    Name = "Diablo 3",
                    Description = "A community for Diablo 3 enthusiasts.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png",
                },
                new Community()
                {
                    Name = "The Witcher Series",
                    Description = "A community for fans of The Witcher series.",
                    ImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png"
                },
                new Community()
                {
                    Name = "Call of Duty",
                    Description = "A gathering spot for Call of Duty players.",
                    ImageUrl = "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg"
                },
                new Community()
                {
                    Name = "League of Legends",
                    Description = "Community for League of Legends players and enthusiasts.",
                    ImageUrl = "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed"
                },
                new Community()
                {
                    Name = "Elder Scrolls",
                    Description = "For fans of the Elder Scrolls series.",
                    ImageUrl = "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg"
                },
                new Community()
                {
                    Name = "Dark Souls",
                    Description = "A community dedicated to the challenging world of Dark Souls.",
                    ImageUrl = "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg"
                },
                new Community()
                {
                    Name = "Assassin's Creed",
                    Description = "Fans of the Assassin's Creed series unite here.",
                    ImageUrl = "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg"
                },
                new Community()
                {
                    Name = "Dota 2",
                    Description = "A hub for Dota 2 players of all levels.",
                    ImageUrl = "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg"
                },
                new Community()
                {
                    Name = "Final Fantasy",
                    Description = "A community for lovers of the Final Fantasy series.",
                    ImageUrl = "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840"
                },
                new Community()
                {
                    Name = "Overwatch",
                    Description = "A place for Overwatch players and fans.",
                    ImageUrl = "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg"
                },
                new Community()
                {
                    Name = "Grand Theft Auto",
                    Description = "Community for enthusiasts of the Grand Theft Auto series.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png"
                }
            };

            return communities;
        }
    }
}

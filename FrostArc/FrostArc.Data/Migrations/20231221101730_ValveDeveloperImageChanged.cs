using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class ValveDeveloperImageChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("012e6d6a-6b7d-48e7-8fed-0ea565bf8198"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("05791e34-7402-4719-986d-fa352fcaa7c4"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("13e5ea0f-09d1-46c4-9428-21b11d4cf8af"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("21df3ccd-2478-4f0a-852f-4c5b2a402cb2"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("6cccfbd9-3f25-4062-907c-4a3bb9f64c20"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("8844e398-c764-40bd-8da8-d735be84e11b"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("93243176-d0e3-4b56-b505-668150b46aa4"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("aef6a689-2e56-4a01-b98a-11ff45c0de2b"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("b11a01fa-ef9d-446a-9326-696a60946c4e"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("cbd4f4e4-94b7-44cb-9ff8-cf1416e3a620"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("dab57e15-0a14-4b33-aae7-c0054fc78c14"));

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("07df849c-64ef-4a84-8691-a60bcdbc57fc"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls" },
                    { new Guid("491ddfa6-590e-4dee-b83b-4f7aba65cc3f"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3" },
                    { new Guid("4cbd6f4e-02b1-4c56-a0aa-a6893af32fa9"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls" },
                    { new Guid("6306ad4f-5b14-470a-b293-475270d83e9d"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch" },
                    { new Guid("836f5295-fc8c-41b9-96c6-f87af767a2db"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series" },
                    { new Guid("88e99aa2-91a9-404a-9083-be0c1e00eef4"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty" },
                    { new Guid("972b3a5d-6847-441d-9386-9e505843145e"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy" },
                    { new Guid("9a2cd602-e90a-4619-9d7b-b78b4603d485"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto" },
                    { new Guid("b04c4baa-02ff-4697-b903-19974a6bd0f8"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends" },
                    { new Guid("d540aaab-2723-4139-bc6e-3428d803e0a8"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed" },
                    { new Guid("efd8a61a-fcb7-4b36-80a6-f4578e579e55"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2" }
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                column: "ImageUrl",
                value: "https://pbs.twimg.com/profile_images/1196563043150204928/X6pfa2YZ_400x400.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("07df849c-64ef-4a84-8691-a60bcdbc57fc"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("491ddfa6-590e-4dee-b83b-4f7aba65cc3f"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("4cbd6f4e-02b1-4c56-a0aa-a6893af32fa9"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("6306ad4f-5b14-470a-b293-475270d83e9d"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("836f5295-fc8c-41b9-96c6-f87af767a2db"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("88e99aa2-91a9-404a-9083-be0c1e00eef4"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("972b3a5d-6847-441d-9386-9e505843145e"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("9a2cd602-e90a-4619-9d7b-b78b4603d485"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("b04c4baa-02ff-4697-b903-19974a6bd0f8"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("d540aaab-2723-4139-bc6e-3428d803e0a8"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("efd8a61a-fcb7-4b36-80a6-f4578e579e55"));

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("012e6d6a-6b7d-48e7-8fed-0ea565bf8198"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch" },
                    { new Guid("05791e34-7402-4719-986d-fa352fcaa7c4"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2" },
                    { new Guid("13e5ea0f-09d1-46c4-9428-21b11d4cf8af"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3" },
                    { new Guid("21df3ccd-2478-4f0a-852f-4c5b2a402cb2"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed" },
                    { new Guid("6cccfbd9-3f25-4062-907c-4a3bb9f64c20"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends" },
                    { new Guid("8844e398-c764-40bd-8da8-d735be84e11b"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto" },
                    { new Guid("93243176-d0e3-4b56-b505-668150b46aa4"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series" },
                    { new Guid("aef6a689-2e56-4a01-b98a-11ff45c0de2b"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy" },
                    { new Guid("b11a01fa-ef9d-446a-9326-696a60946c4e"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls" },
                    { new Guid("cbd4f4e4-94b7-44cb-9ff8-cf1416e3a620"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty" },
                    { new Guid("dab57e15-0a14-4b33-aae7-c0054fc78c14"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls" }
                });

            migrationBuilder.UpdateData(
                table: "Developers",
                keyColumn: "Id",
                keyValue: new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                column: "ImageUrl",
                value: "https://static.wikia.nocookie.net/half-life/images/6/68/2560px-Valve_logo.svg.png/revision/latest?cb=20200325103915&path-prefix=en");
        }
    }
}

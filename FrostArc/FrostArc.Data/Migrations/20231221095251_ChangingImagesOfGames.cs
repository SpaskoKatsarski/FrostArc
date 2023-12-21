using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangingImagesOfGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("45780d53-622b-4b5b-8e0c-c5af643d9ea2"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("48b7aede-6de7-4c50-b605-4be177f62eff"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("60877472-373f-457d-b11b-527c5d019587"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("7c62cf59-59fe-4ef2-ac6b-2889e4aff373"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("8e307a81-f269-4c9c-b800-bf0a3926e919"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("90c59384-bbfd-4a37-a14f-86094c024c47"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("a31aa622-1e7d-491a-b471-b1c72e1836ee"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("c7c19472-58cb-43f4-87a1-4a05dd51d1d1"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("e6d46afa-5f5a-4cb0-b468-3f6da2dc70ac"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("fd07abf5-45a2-48f9-a2e1-8af8a88d28f5"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("ffe5c080-2bac-4682-a623-b52559c0e98a"));

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
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"),
                column: "ImageUrl",
                value: "https://image.api.playstation.com/cdn/EP0002/CUSA05379_00/iTxbX14rj7Qhk3zYc6bnmDiuXMIK2UUW.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"),
                column: "ImageUrl",
                value: "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"),
                column: "ImageUrl",
                value: "https://stryda.gg/_next/image?url=https%3A%2F%2Fwww.datocms-assets.com%2F92583%2F1675777489-league-of-legends-cover.webp&w=1280&q=75");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"),
                column: "ImageUrl",
                value: "https://image.api.playstation.com/cdn/EP0700/CUSA03365_00/OFMeAw2KhrdaEZAjW1f3tCIXbogkLpTC.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"),
                column: "ImageUrl",
                value: "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("56b33636-b50f-4c0f-940a-8f361428b330"),
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/en/5/5a/FF_XV_cover_art.jpg");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"),
                column: "ImageUrl",
                value: "https://blz-contentstack-images.akamaized.net/v3/assets/blt2477dcaf4ebd440c/bltdabc3782553659f1/650cc84db1e5551677dcd71d/ow2_xboxshowcase_static_7.png?format=webply&quality=90");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"),
                column: "ImageUrl",
                value: "https://image.api.playstation.com/cdn/EP0001/CUSA09303_00/tzKcptCCUkiigpacybO8xWmvxPS7vIzk.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("94640685-0e93-47aa-81aa-ff19991dc088"),
                column: "ImageUrl",
                value: "https://cdn.akamai.steamstatic.com/steam/apps/271590/capsule_616x353.jpg?t=1695060909");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"),
                column: "ImageUrl",
                value: "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("45780d53-622b-4b5b-8e0c-c5af643d9ea2"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto" },
                    { new Guid("48b7aede-6de7-4c50-b605-4be177f62eff"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series" },
                    { new Guid("60877472-373f-457d-b11b-527c5d019587"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls" },
                    { new Guid("7c62cf59-59fe-4ef2-ac6b-2889e4aff373"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends" },
                    { new Guid("8e307a81-f269-4c9c-b800-bf0a3926e919"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed" },
                    { new Guid("90c59384-bbfd-4a37-a14f-86094c024c47"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty" },
                    { new Guid("a31aa622-1e7d-491a-b471-b1c72e1836ee"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch" },
                    { new Guid("c7c19472-58cb-43f4-87a1-4a05dd51d1d1"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy" },
                    { new Guid("e6d46afa-5f5a-4cb0-b468-3f6da2dc70ac"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3" },
                    { new Guid("fd07abf5-45a2-48f9-a2e1-8af8a88d28f5"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2" },
                    { new Guid("ffe5c080-2bac-4682-a623-b52559c0e98a"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls" }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"),
                column: "ImageUrl",
                value: "https://example.com/cod_mw_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"),
                column: "ImageUrl",
                value: "https://example.com/skyrim_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"),
                column: "ImageUrl",
                value: "https://example.com/lol_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"),
                column: "ImageUrl",
                value: "https://example.com/darksouls3_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"),
                column: "ImageUrl",
                value: "https://example.com/witcher3_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("56b33636-b50f-4c0f-940a-8f361428b330"),
                column: "ImageUrl",
                value: "https://example.com/ffxv_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"),
                column: "ImageUrl",
                value: "https://example.com/overwatch_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"),
                column: "ImageUrl",
                value: "https://example.com/ac_odyssey_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("94640685-0e93-47aa-81aa-ff19991dc088"),
                column: "ImageUrl",
                value: "https://example.com/gtav_image.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"),
                column: "ImageUrl",
                value: "https://example.com/dota2_image.png");
        }
    }
}

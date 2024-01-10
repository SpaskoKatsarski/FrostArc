using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveGamesFromPlatforms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_PlatformId",
                table: "Games");

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("1e51d60e-77fc-41ae-832c-b088aa459547"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("332418d2-b251-4135-a4de-8edef40889b6"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("346d3c49-5a47-4afa-9367-8e66f2544a36"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("5a1bf0f3-4653-443a-a1b4-5cc55dd039f1"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("890c3b3d-8134-4e9b-b60d-13d7c3a292aa"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("91d01dfd-9fa7-49fc-82ed-7f710964aea8"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("abc80c78-aa02-449a-94fc-64f67a087eb1"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("d56e9d97-53a3-4af6-a9ba-8752cf108adb"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("eb8bb860-56e8-406d-9c90-e1883e2695d5"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f3c49b56-fa1f-48e5-a49b-fe3dda783e40"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f7d408f6-f348-4cd2-a1c6-b8fd0f56899d"));

            migrationBuilder.DropColumn(
                name: "PlatformId",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                column: "ConcurrencyStamp",
                value: "f889ddaf-3f8e-452e-b22f-4d7b63c170f5");

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("075ba0c9-f35c-4b6a-9113-68f39e737506"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("5e0621f0-9de6-4133-b544-c7502a7b54f8"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("795d3cde-7f7a-4abc-aa8a-4ace907fa10f"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("888594d6-930d-4763-9fce-c8eeb51f4f28"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("94550e72-2b4b-4b83-9404-41572b52cc86"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("adc71488-afcf-4db5-b295-13e4998dbb59"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("cdfbe3d9-6cef-4a83-9523-0a896b9a4f54"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("e0c51bc3-c141-4d6f-b74a-011be5590aad"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("e4088e39-7552-4152-a9fa-8a8ef48e086e"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f2bf8094-f908-4067-a930-f551944bdc16"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f45a23d2-86d1-4401-b1f2-e3ef9d01606c"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("075ba0c9-f35c-4b6a-9113-68f39e737506"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("5e0621f0-9de6-4133-b544-c7502a7b54f8"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("795d3cde-7f7a-4abc-aa8a-4ace907fa10f"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("888594d6-930d-4763-9fce-c8eeb51f4f28"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("94550e72-2b4b-4b83-9404-41572b52cc86"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("adc71488-afcf-4db5-b295-13e4998dbb59"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("cdfbe3d9-6cef-4a83-9523-0a896b9a4f54"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("e0c51bc3-c141-4d6f-b74a-011be5590aad"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("e4088e39-7552-4152-a9fa-8a8ef48e086e"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f2bf8094-f908-4067-a930-f551944bdc16"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f45a23d2-86d1-4401-b1f2-e3ef9d01606c"));

            migrationBuilder.AddColumn<int>(
                name: "PlatformId",
                table: "Games",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                column: "ConcurrencyStamp",
                value: "0ab79d34-19b0-4e88-b86f-456f18b2469a");

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("1e51d60e-77fc-41ae-832c-b088aa459547"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("332418d2-b251-4135-a4de-8edef40889b6"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("346d3c49-5a47-4afa-9367-8e66f2544a36"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("5a1bf0f3-4653-443a-a1b4-5cc55dd039f1"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("890c3b3d-8134-4e9b-b60d-13d7c3a292aa"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("91d01dfd-9fa7-49fc-82ed-7f710964aea8"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("abc80c78-aa02-449a-94fc-64f67a087eb1"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("d56e9d97-53a3-4af6-a9ba-8752cf108adb"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("eb8bb860-56e8-406d-9c90-e1883e2695d5"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f3c49b56-fa1f-48e5-a49b-fe3dda783e40"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f7d408f6-f348-4cd2-a1c6-b8fd0f56899d"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("56b33636-b50f-4c0f-940a-8f361428b330"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("94640685-0e93-47aa-81aa-ff19991dc088"),
                column: "PlatformId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"),
                column: "PlatformId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Games_PlatformId",
                table: "Games",
                column: "PlatformId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Platforms_PlatformId",
                table: "Games",
                column: "PlatformId",
                principalTable: "Platforms",
                principalColumn: "Id");
        }
    }
}

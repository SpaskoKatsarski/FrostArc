using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingCommunityOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "OwnerId",
                table: "Communities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"), 0, "89560bfe-44c9-42aa-85fe-ac17e0ab0490", "SyncK", null, false, false, null, null, null, null, null, false, "https://cdn-icons-png.flaticon.com/512/1053/1053244.png", null, false, null });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("1a752584-4820-4024-b603-b10832178405"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("360f690c-2da8-45b2-ace9-940cd40bf4f6"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("38c911de-afe4-4c76-be41-eb56be7dfdb7"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("3d457709-29ed-455e-8266-c23b3741a000"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("3f847107-0ff8-4439-a864-a7d2d3811430"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("662756cf-741b-41e6-b721-291d768aaf59"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("7d668249-c217-4869-9875-a29e7fa2cef0"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("829c835f-92df-4d9d-a73c-10c7e1811c38"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("b2a0ac1a-2be0-432a-8b19-27f362a36823"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("e87f0aa6-e1f4-448e-bf14-03c9e49bf91b"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("ffd23f8a-b4de-4325-b968-e6d8ef2f0dc8"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communities_OwnerId",
                table: "Communities",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Communities_AspNetUsers_OwnerId",
                table: "Communities",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Communities_AspNetUsers_OwnerId",
                table: "Communities");

            migrationBuilder.DropIndex(
                name: "IX_Communities_OwnerId",
                table: "Communities");

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("1a752584-4820-4024-b603-b10832178405"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("360f690c-2da8-45b2-ace9-940cd40bf4f6"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("38c911de-afe4-4c76-be41-eb56be7dfdb7"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("3d457709-29ed-455e-8266-c23b3741a000"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("3f847107-0ff8-4439-a864-a7d2d3811430"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("662756cf-741b-41e6-b721-291d768aaf59"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("7d668249-c217-4869-9875-a29e7fa2cef0"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("829c835f-92df-4d9d-a73c-10c7e1811c38"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("b2a0ac1a-2be0-432a-8b19-27f362a36823"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("e87f0aa6-e1f4-448e-bf14-03c9e49bf91b"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("ffd23f8a-b4de-4325-b968-e6d8ef2f0dc8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"));

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Communities");

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
        }
    }
}

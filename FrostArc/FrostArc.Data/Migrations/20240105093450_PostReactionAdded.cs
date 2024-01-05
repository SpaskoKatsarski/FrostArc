using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class PostReactionAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("0912fb7e-99b3-47ab-87ee-aeb351de85b0"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("181f3c97-8af1-4a89-a9e9-4ff92e5225a9"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("1a405d21-6bf3-4fb5-a4ad-32b02d018f19"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("23084b9c-109f-4d21-bb86-1dfc82ad2348"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("35b03930-8c7d-42c5-b111-03acbe815f43"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("426438e5-076c-4483-bc7c-ad6611970d12"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("57ca66f2-f7ba-460f-b4a2-ac2ef6ba21ce"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("5ff620f6-1fe3-4c9f-ae51-7f6d85908f63"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("8d4e9288-4f1f-4bf9-a557-e1c956b0013c"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("a41a0388-0319-4933-bd3a-45c976a9faac"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("d0732ae5-270b-4625-a793-82adf670ff6a"));

            migrationBuilder.CreateTable(
                name: "PostsReactions",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostsReactions", x => new { x.PostId, x.UserId });
                    table.ForeignKey(
                        name: "FK_PostsReactions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostsReactions_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                column: "ConcurrencyStamp",
                value: "0adb3e32-3ca2-4bc9-a606-6f5073ae5427");

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("2fe2b927-6751-45d7-85ae-a3a3d48376e9"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("423faaf4-e3dd-474f-8420-e0ca1397eae1"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("42420f5e-56ac-4213-9756-a36fb219317c"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("6803b3da-f173-46e6-bcb5-5a37d895ec4c"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("84814aa6-f601-4c52-8544-73c3c5fdeeec"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("8a4ac17c-5ddd-47bd-9e87-da391a71a57e"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("b4c81d28-71d4-4914-ae54-74078310f43a"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("b6c2f8ce-e3fa-4eef-bf18-bfa4397794bb"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("c021ceb9-2173-44ce-9f49-c02bd5edbffa"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f12ae856-c05f-4294-9cea-1049b7a88b69"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f32ac296-3559-45e5-8838-9aa382dcfaea"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostsReactions_UserId",
                table: "PostsReactions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostsReactions");

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("2fe2b927-6751-45d7-85ae-a3a3d48376e9"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("423faaf4-e3dd-474f-8420-e0ca1397eae1"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("42420f5e-56ac-4213-9756-a36fb219317c"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("6803b3da-f173-46e6-bcb5-5a37d895ec4c"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("84814aa6-f601-4c52-8544-73c3c5fdeeec"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("8a4ac17c-5ddd-47bd-9e87-da391a71a57e"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("b4c81d28-71d4-4914-ae54-74078310f43a"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("b6c2f8ce-e3fa-4eef-bf18-bfa4397794bb"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("c021ceb9-2173-44ce-9f49-c02bd5edbffa"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f12ae856-c05f-4294-9cea-1049b7a88b69"));

            migrationBuilder.DeleteData(
                table: "Communities",
                keyColumn: "Id",
                keyValue: new Guid("f32ac296-3559-45e5-8838-9aa382dcfaea"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                column: "ConcurrencyStamp",
                value: "4d1dd3cf-8a52-4996-b94a-ecd5336a91e5");

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("0912fb7e-99b3-47ab-87ee-aeb351de85b0"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("181f3c97-8af1-4a89-a9e9-4ff92e5225a9"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("1a405d21-6bf3-4fb5-a4ad-32b02d018f19"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("23084b9c-109f-4d21-bb86-1dfc82ad2348"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("35b03930-8c7d-42c5-b111-03acbe815f43"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("426438e5-076c-4483-bc7c-ad6611970d12"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("57ca66f2-f7ba-460f-b4a2-ac2ef6ba21ce"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("5ff620f6-1fe3-4c9f-ae51-7f6d85908f63"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("8d4e9288-4f1f-4bf9-a557-e1c956b0013c"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("a41a0388-0319-4933-bd3a-45c976a9faac"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("d0732ae5-270b-4625-a793-82adf670ff6a"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });
        }
    }
}

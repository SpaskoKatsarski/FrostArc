using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingDefaultValueToPostLikesAndDislikes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Dislikes",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Likes",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Dislikes",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                column: "ConcurrencyStamp",
                value: "89560bfe-44c9-42aa-85fe-ac17e0ab0490");

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
        }
    }
}

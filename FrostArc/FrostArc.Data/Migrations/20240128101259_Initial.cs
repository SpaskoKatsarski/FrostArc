using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false, defaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Developers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeveloperId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Developers_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserCommunity",
                columns: table => new
                {
                    CommunitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserCommunity", x => new { x.CommunitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserCommunity_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserCommunity_Communities_CommunitiesId",
                        column: x => x.CommunitiesId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true),
                    Likes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Dislikes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GamesPlatforms",
                columns: table => new
                {
                    GameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamesPlatforms", x => new { x.GameId, x.PlatformId });
                    table.ForeignKey(
                        name: "FK_GamesPlatforms_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamesPlatforms_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostsReactions",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Like = table.Column<bool>(type: "bit", nullable: false),
                    Dislike = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"), 0, "0cea04ce-d02d-4b81-89db-36ca04d2d3a3", "SyncK", "spasko@abv.bg", false, true, null, "SPASKO@ABV.BG", "SPASKO@ABV.BG", "AQAAAAIAAYagAAAAEHcm2ntJ8Uzl2TsMSCyx0uHTs/FB4Y5bx4LYCuqdrPp9Y7lE1o8S/xWaC27OPNXNDg==", null, false, "https://cdn-icons-png.flaticon.com/512/1053/1053244.png", "1BC726483DA146C7AB96961EBD8FA88B", false, "spasko@abv.bg" });

            migrationBuilder.InsertData(
                table: "Developers",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"), "American video game publisher, famous for the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/53/Rockstar_Games_Logo.svg/1200px-Rockstar_Games_Logo.svg.png", false, "Rockstar Games" },
                    { new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), "Polish video game developer known for The Witcher series.", "https://upload.wikimedia.org/wikipedia/en/thumb/6/68/CD_Projekt_logo.svg/1200px-CD_Projekt_logo.svg.png", false, "CD Projekt Red" },
                    { new Guid("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), "American video game developer, creator of the Call of Duty series.", "https://static.wikia.nocookie.net/cod_esports_gamepedia_en/images/d/d7/Infinty_Ward_logo.png/revision/latest?cb=20200707211638", false, "Infinity Ward" },
                    { new Guid("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"), "American video game developer known for League of Legends.", "https://www.riotgames.com/darkroom/800/87521fcaeca5867538ae7f46ac152740:2f8144e17957078916e41d2410c111c3/002-rg-2021-full-lockup-offwhite.jpg", false, "Riot Games" },
                    { new Guid("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"), "American video game developer, famous for the Elder Scrolls series.", "https://images.ctfassets.net/rporu91m20dc/4gNvwblcIUQMAa0QWakgAk/64625a987bad1812862748367703938b/BGS_LargeHero_Future.jpg", false, "Bethesda Game Studios" },
                    { new Guid("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"), "Japanese video game development company, renowned for the Dark Souls series.", "https://static.wikia.nocookie.net/sony-playstation/images/f/fe/FromSoftware_logo_black_background.png/revision/latest?cb=20220901192200", false, "FromSoftware" },
                    { new Guid("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"), "French video game company, known for creating the Assassin's Creed series.", "https://staticctf.akamaized.net/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/3h4s0GE47IBDxheVyJkfuX/e854163c0246c91bd79f390e9414391e/ubisoft_logo_whiteonblack_960x540_351175.jpg", false, "Ubisoft" },
                    { new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"), "American video game developer, publisher and digital distribution company, known for Dota 2.", "https://pbs.twimg.com/profile_images/1196563043150204928/X6pfa2YZ_400x400.jpg", false, "Valve Corporation" },
                    { new Guid("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"), "Japanese video game developer, publisher, and distribution company, famous for the Final Fantasy series.", "https://www.hd.square-enix.com/eng/assets/img/og/ogp_square-enix.png", false, "Square Enix" },
                    { new Guid("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"), "American video game developer and publisher, known for Overwatch.", "https://blz-contentstack-images.akamaized.net/v3/assets/blta8f9a8e092360c6c/bltbe1a42777abcc0da/620d1898a38b0106946f17d2/thumbnail-home.jpg", false, "Blizzard Entertainment" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Games emphasizing physical challenges, including hand–eye coordination and reaction time.", false, "Action" },
                    { 2, "Games focusing on exploration, puzzle-solving, and narrative.", false, "Adventure" },
                    { 3, "Games where players assume the roles of characters in a fictional setting.", false, "RPG (Role-Playing Game)" },
                    { 4, "Games designed to simulate real-world activities.", false, "Simulation" },
                    { 5, "Games where the focus is on strategic decision making.", false, "Strategy" },
                    { 6, "Games that simulate the playing of sports.", false, "Sports" },
                    { 7, "Games that involve racing against opponents.", false, "Racing" },
                    { 8, "Games centered around close-ranged combat between a limited number of characters.", false, "Fighting" },
                    { 9, "Games focusing on combat with various firearms.", false, "Shooter" },
                    { 10, "Online games capable of supporting large numbers of players simultaneously.", false, "MMO (Massively Multiplayer Online)" },
                    { 11, "Games featuring two opposing teams competing against each other.", false, "MOBA (Multiplayer Online Battle Arena)" },
                    { 12, "Games designed to scare the player with an ominous atmosphere and chilling storylines.", false, "Horror" },
                    { 13, "Games that challenge the player's problem-solving skills.", false, "Puzzle" },
                    { 14, "Games that challenge the player's sense of rhythm and music timing.", false, "Music/Rhythm" },
                    { 15, "Games with an educational component, often aimed at younger players.", false, "Educational" },
                    { 16, "Games focusing on jumping and climbing through levels with uneven terrain.", false, "Platformer" },
                    { 17, "Games where players often engage in gameplay focused on stealth and not being seen.", false, "Stealth" },
                    { 18, "Games focusing on survival of the player as a primary goal.", false, "Survival" },
                    { 19, "Games designed to be played using virtual reality equipment.", false, "VR (Virtual Reality)" },
                    { 20, "Games that blend the real-world environment with game elements.", false, "AR (Augmented Reality)" },
                    { 21, "Games produced by individual developers or small teams without substantial financial backing.", false, "Indie" },
                    { 22, "Games that allow a high degree of player freedom with minimal limitations.", false, "Sandbox" },
                    { 23, "Games featuring large numbers of players competing to be the last person standing.", false, "Battle Royale" }
                });

            migrationBuilder.InsertData(
                table: "Platforms",
                columns: new[] { "Id", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "Games available for personal computers.", false, "PC" },
                    { 2, "Games available for PlayStation consoles.", false, "PlayStation" },
                    { 3, "Games available for Xbox consoles.", false, "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "Communities",
                columns: new[] { "Id", "Description", "ImageUrl", "IsDeleted", "Name", "OwnerId" },
                values: new object[,]
                {
                    { new Guid("1177b3c1-0f40-471a-99fa-6f00fef2e672"), "Community for League of Legends players and enthusiasts.", "https://cdn1.epicgames.com/offer/24b9b5e323bc40eea252a10cdd3b2f10/EGS_LeagueofLegends_RiotGames_S1_2560x1440-872a966297484acd0efe49f34edd5aed", false, "League of Legends", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("4c770262-3889-4ef3-9899-c1d97f3ae8dc"), "Fans of the Assassin's Creed series unite here.", "https://staticctf.ubisoft.com/J3yJr34U2pZ2Ieem48Dwy9uqj5PNUQTn/449BBgnc3Q1ha2IN9rh3bR/e1077125021162ce2d59820739c316e7/ACEC_Keyart_00_00_00_mobile.jpg", false, "Assassin's Creed", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("5ad3fedc-4a19-4915-b59d-f7d385277d06"), "A place for Overwatch players and fans.", "https://media.wired.com/photos/642c752dc18cf0c5f132190d/master/pass/Overwatch-2-Lifeweaver-Gear.jpg", false, "Overwatch", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("5d10d6d7-6223-482a-a98c-2ab4a3c4cfe2"), "A community for lovers of the Final Fantasy series.", "https://fyre.cdn.sewest.net/ffvii-hub/6471442498774a5fd66555de/pub106_cloud_zack_sephiroth-3-1--ga4rX0dsG.jpg?quality=85&width=3840", false, "Final Fantasy", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("6cde4016-6159-4ff9-8581-b0de4e1a7dc5"), "Community for enthusiasts of the Grand Theft Auto series.", "https://upload.wikimedia.org/wikipedia/en/a/a5/Grand_Theft_Auto_V.png", false, "Grand Theft Auto", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("73a36f6e-9f3d-420b-bcb6-63c3980d9e98"), "A gathering spot for Call of Duty players.", "https://www.callofduty.com/content/dam/atvi/callofduty/cod-touchui/mw2/home/reveal/new-era/new_era-mw2.jpg", false, "Call of Duty", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("9a7fba4c-ff70-4f3f-a17e-d6369cbf1974"), "A community dedicated to the challenging world of Dark Souls.", "https://media.wired.co.uk/photos/606db938d051e15de128ccb1/4:3/w_2876,h_2157,c_limit/crop.jpg", false, "Dark Souls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("a10c0f03-7cf2-4128-b74a-5f324d8d1027"), "A community for fans of The Witcher series.", "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, "The Witcher Series", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("a7eb244f-6e4a-45b6-9b6f-6b16feda05d9"), "A hub for Dota 2 players of all levels.", "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, "Dota 2", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("c52fa30e-027a-471f-9839-a8fdea12562c"), "For fans of the Elder Scrolls series.", "https://esosslfiles-a.akamaihd.net/cms/2021/11/f5059a45d236626bd8ba7433c488bbe7.jpg", false, "Elder Scrolls", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") },
                    { new Guid("f37eedfe-96ed-4448-a0de-48392e7ae50d"), "A community for Diablo 3 enthusiasts.", "https://upload.wikimedia.org/wikipedia/en/8/80/Diablo_III_cover.png", false, "Diablo 3", new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a") }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "DeveloperId", "GenreId", "ImageUrl", "IsDeleted", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), "A first-person shooter with intense campaigns and multiplayer modes.", new Guid("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), 9, "https://image.api.playstation.com/cdn/EP0002/CUSA05379_00/iTxbX14rj7Qhk3zYc6bnmDiuXMIK2UUW.png", false, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call of Duty: Modern Warfare" },
                    { new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), "An open-world action RPG set in a detailed fantasy world.", new Guid("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"), 3, "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w.jpg", false, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Elder Scrolls V: Skyrim" },
                    { new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"), "A highly popular multiplayer online battle arena game.", new Guid("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"), 11, "https://stryda.gg/_next/image?url=https%3A%2F%2Fwww.datocms-assets.com%2F92583%2F1675777489-league-of-legends-cover.webp&w=1280&q=75", false, new DateTime(2009, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "League of Legends" },
                    { new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), "A challenging and intricate action RPG known for its difficulty.", new Guid("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"), 3, "https://image.api.playstation.com/cdn/EP0700/CUSA03365_00/OFMeAw2KhrdaEZAjW1f3tCIXbogkLpTC.png", false, new DateTime(2016, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark Souls III" },
                    { new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), "An open-world RPG set in a gritty fantasy universe.", new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), 3, "https://image.api.playstation.com/vulcan/ap/rnd/202211/0711/kh4MUIuMmHlktOHar3lVl6rY.png", false, new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher 3: Wild Hunt" },
                    { new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), "A fantasy RPG with an emphasis on fast-paced action and character-driven storytelling.", new Guid("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"), 3, "https://upload.wikimedia.org/wikipedia/en/5/5a/FF_XV_cover_art.jpg", false, new DateTime(2016, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Final Fantasy XV" },
                    { new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), "A team-based multiplayer first-person shooter with a wide range of unique heroes.", new Guid("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"), 9, "https://blz-contentstack-images.akamaized.net/v3/assets/blt2477dcaf4ebd440c/bltdabc3782553659f1/650cc84db1e5551677dcd71d/ow2_xboxshowcase_static_7.png?format=webply&quality=90", false, new DateTime(2016, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Overwatch" },
                    { new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), "An action RPG set in ancient Greece, part of the Assassin's Creed series.", new Guid("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"), 3, "https://image.api.playstation.com/cdn/EP0001/CUSA09303_00/tzKcptCCUkiigpacybO8xWmvxPS7vIzk.png", false, new DateTime(2018, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Assassin's Creed Odyssey" },
                    { new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), "An action-adventure game set in a fictional state, featuring an open world and a story-driven campaign.", new Guid("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"), 2, "https://cdn.akamai.steamstatic.com/steam/apps/271590/capsule_616x353.jpg?t=1695060909", false, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grand Theft Auto V" },
                    { new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"), "A popular MOBA game known for its strategic depth and complexity.", new Guid("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"), 11, "https://cdn.cloudflare.steamstatic.com/apps/dota2/images/dota2_social.jpg", false, new DateTime(2013, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dota 2" }
                });

            migrationBuilder.InsertData(
                table: "GamesPlatforms",
                columns: new[] { "GameId", "PlatformId" },
                values: new object[,]
                {
                    { new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), 1 },
                    { new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), 2 },
                    { new Guid("006ac6dc-26d9-4524-a5d1-ed1f4a1b6a04"), 3 },
                    { new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), 1 },
                    { new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), 2 },
                    { new Guid("07d121f2-1896-4397-a014-3f3b0dd5e55e"), 3 },
                    { new Guid("1a7db5c2-a562-4828-bc20-84c6021a5623"), 1 },
                    { new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), 1 },
                    { new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), 2 },
                    { new Guid("2b5cb595-19b5-445d-9f45-b6189687f483"), 3 },
                    { new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), 1 },
                    { new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), 2 },
                    { new Guid("32bb0d8c-9d51-400b-b4a8-e3f8fe704af0"), 3 },
                    { new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), 1 },
                    { new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), 2 },
                    { new Guid("56b33636-b50f-4c0f-940a-8f361428b330"), 3 },
                    { new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), 1 },
                    { new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), 2 },
                    { new Guid("653964dc-2cbd-4ba7-96dd-a5ebc0f59508"), 3 },
                    { new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), 1 },
                    { new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), 2 },
                    { new Guid("6de757b8-ee9d-4347-9845-a2c95c295749"), 3 },
                    { new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), 1 },
                    { new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), 2 },
                    { new Guid("94640685-0e93-47aa-81aa-ff19991dc088"), 3 },
                    { new Guid("e15f1653-b0ef-4512-969c-1b3b6594251e"), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserCommunity_UsersId",
                table: "ApplicationUserCommunity",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_OwnerId",
                table: "Communities",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_DeveloperId",
                table: "Games",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_GamesPlatforms_PlatformId",
                table: "GamesPlatforms",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CommunityId",
                table: "Posts",
                column: "CommunityId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostsReactions_UserId",
                table: "PostsReactions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserCommunity");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "GamesPlatforms");

            migrationBuilder.DropTable(
                name: "PostsReactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Developers");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingModeratorCommunityEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ModeratorsCommunities",
                columns: table => new
                {
                    ModeratorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommunityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeratorsCommunities", x => new { x.ModeratorId, x.CommunityId });
                    table.ForeignKey(
                        name: "FK_ModeratorsCommunities_AspNetUsers_ModeratorId",
                        column: x => x.ModeratorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModeratorsCommunities_Communities_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Communities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d4e4af5-2ed4-43bb-a23c-153598b15ce8", "AQAAAAIAAYagAAAAEKdyROSgLZ4rPTasOv2T+TNYgQszXd8vtHkXrkHtZBpDP3VCcfT6+LDiTKwpMQhIHw==" });

            migrationBuilder.CreateIndex(
                name: "IX_ModeratorsCommunities_CommunityId",
                table: "ModeratorsCommunities",
                column: "CommunityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModeratorsCommunities");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3e6fad8c-8b75-45fa-b6ed-12027466320a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0cea04ce-d02d-4b81-89db-36ca04d2d3a3", "AQAAAAIAAYagAAAAEHcm2ntJ8Uzl2TsMSCyx0uHTs/FB4Y5bx4LYCuqdrPp9Y7lE1o8S/xWaC27OPNXNDg==" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePicAddedToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                defaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "AspNetUsers");
        }
    }
}

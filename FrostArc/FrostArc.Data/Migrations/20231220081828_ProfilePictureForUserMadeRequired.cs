using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePictureForUserMadeRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: false,
                defaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true,
                oldDefaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePicture",
                table: "AspNetUsers",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                defaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldDefaultValue: "https://cdn-icons-png.flaticon.com/512/1053/1053244.png");
        }
    }
}

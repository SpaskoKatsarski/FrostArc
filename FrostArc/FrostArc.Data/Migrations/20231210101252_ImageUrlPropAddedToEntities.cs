using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrostArc.Data.Migrations
{
    /// <inheritdoc />
    public partial class ImageUrlPropAddedToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Platforms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Communities",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Platforms");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Communities");
        }
    }
}

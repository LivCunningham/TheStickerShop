using Microsoft.EntityFrameworkCore.Migrations;

namespace thestickershop.Migrations
{
    public partial class addingnewstockprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InStock",
                table: "StickerItems");

            migrationBuilder.AddColumn<int>(
                name: "ActualStock",
                table: "StickerItems",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualStock",
                table: "StickerItems");

            migrationBuilder.AddColumn<bool>(
                name: "InStock",
                table: "StickerItems",
                nullable: false,
                defaultValue: false);
        }
    }
}

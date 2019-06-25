using Microsoft.EntityFrameworkCore.Migrations;

namespace thestickershop.Migrations
{
    public partial class addingendpoints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InStock",
                table: "StickerItems",
                nullable: false,
                oldClrType: typeof(bool));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "InStock",
                table: "StickerItems",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}

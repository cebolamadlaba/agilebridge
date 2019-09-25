using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileBridgeAss.Migrations
{
    public partial class AgileBridgeAssMenuItemDataAgileBridgeContexts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "MenuItem",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "MenuItem",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

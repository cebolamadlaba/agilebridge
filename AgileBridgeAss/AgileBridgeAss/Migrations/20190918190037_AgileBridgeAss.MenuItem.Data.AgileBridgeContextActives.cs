using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileBridgeAss.Migrations
{
    public partial class AgileBridgeAssMenuItemDataAgileBridgeContextActives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "MenuItem",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "MenuItem");
        }
    }
}

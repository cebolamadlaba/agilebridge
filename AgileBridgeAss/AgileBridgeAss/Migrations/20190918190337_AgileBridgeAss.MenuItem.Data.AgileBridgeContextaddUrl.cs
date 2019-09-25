using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileBridgeAss.Migrations
{
    public partial class AgileBridgeAssMenuItemDataAgileBridgeContextaddUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "MenuItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "MenuItem");
        }
    }
}

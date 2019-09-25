using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileBridgeAss.Migrations
{
    public partial class AgileBridgeAssMenuItemDataAgileBridgeContextActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAtive",
                table: "Role",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Role",
                newName: "IsAtive");
        }
    }
}

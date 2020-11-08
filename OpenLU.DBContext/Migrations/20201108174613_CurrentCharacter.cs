using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenLU.DBContext.Migrations
{
    public partial class CurrentCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CurrentCharId",
                table: "Users",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCharId",
                table: "Users");
        }
    }
}

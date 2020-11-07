using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenLU.DBContext.Migrations
{
    public partial class CharZone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<ushort>(
                name: "Zone",
                table: "Characters",
                nullable: false,
                defaultValue: (ushort)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zone",
                table: "Characters");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenLU.DBContext.Migrations
{
    public partial class InventoryFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Characters_CharacterId",
                table: "InventoryItems");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "InventoryItems",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Characters_CharacterId",
                table: "InventoryItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryItems_Characters_CharacterId",
                table: "InventoryItems");

            migrationBuilder.AlterColumn<long>(
                name: "CharacterId",
                table: "InventoryItems",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryItems_Characters_CharacterId",
                table: "InventoryItems",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

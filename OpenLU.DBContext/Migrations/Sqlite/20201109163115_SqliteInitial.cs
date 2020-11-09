using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenLU.DBContext.Migrations.Sqlite
{
    public partial class SqliteInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CurrentCharId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    FreeToPlay = table.Column<bool>(nullable: false),
                    HeadColor = table.Column<uint>(nullable: false),
                    Head = table.Column<uint>(nullable: false),
                    ShirtColor = table.Column<uint>(nullable: false),
                    ShirtStyle = table.Column<uint>(nullable: false),
                    PantsStyle = table.Column<uint>(nullable: false),
                    PantsColor = table.Column<uint>(nullable: false),
                    HairStyle = table.Column<uint>(nullable: false),
                    HairColor = table.Column<uint>(nullable: false),
                    LH = table.Column<uint>(nullable: false),
                    RH = table.Column<uint>(nullable: false),
                    Eyebrows = table.Column<uint>(nullable: false),
                    Eyes = table.Column<uint>(nullable: false),
                    Mouth = table.Column<uint>(nullable: false),
                    Zone = table.Column<ushort>(nullable: false),
                    LastMapInstance = table.Column<ushort>(nullable: false),
                    LastMapClone = table.Column<uint>(nullable: false),
                    LastLogin = table.Column<ulong>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Lot = table.Column<uint>(nullable: false),
                    Equipped = table.Column<bool>(nullable: false),
                    CharacterId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InventoryItems_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItems_CharacterId",
                table: "InventoryItems",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Password",
                table: "Users",
                column: "Password",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItems");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

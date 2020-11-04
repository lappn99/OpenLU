using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenLU.DBContext.Migrations
{
    public partial class _04112020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "ShirtStyle",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "ShirtColor",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "RH",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "PantsStyle",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "PantsColor",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "Mouth",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<ushort>(
                name: "LastMapInstance",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "LastMapClone",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "LH",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "HairStyle",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "Eyes",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<uint>(
                name: "Eyebrows",
                table: "Characters",
                nullable: false,
                oldClrType: typeof(int),
                
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Characters",
                
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.None);

            migrationBuilder.AddColumn<uint>(
                name: "HairColor",
                table: "Characters",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<ulong>(
                name: "LastLogin",
                table: "Characters",
                nullable: false,
                defaultValue: 0ul);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HairColor",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "ShirtStyle",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "ShirtColor",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "RH",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "PantsStyle",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "PantsColor",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "Mouth",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "LastMapInstance",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(ushort));

            migrationBuilder.AlterColumn<int>(
                name: "LastMapClone",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "LH",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "HairStyle",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "Eyes",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "Eyebrows",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(uint));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Characters",
                type: "int",
                nullable: false,
                oldClrType: typeof(long))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);
        }
    }
}

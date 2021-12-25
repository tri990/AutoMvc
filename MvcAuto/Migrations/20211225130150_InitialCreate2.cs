using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcAuto.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Manufacturer_ManufacturerId",
                table: "Auto");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Auto",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerName",
                table: "Auto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Manufacturer_ManufacturerId",
                table: "Auto",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auto_Manufacturer_ManufacturerId",
                table: "Auto");

            migrationBuilder.DropColumn(
                name: "ManufacturerName",
                table: "Auto");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Auto",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Auto_Manufacturer_ManufacturerId",
                table: "Auto",
                column: "ManufacturerId",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

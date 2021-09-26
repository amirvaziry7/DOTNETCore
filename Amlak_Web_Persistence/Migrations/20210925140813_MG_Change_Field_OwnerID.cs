using Microsoft.EntityFrameworkCore.Migrations;

namespace Amlak_Web_Persistence.Migrations
{
    public partial class MG_Change_Field_OwnerID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ground_Owners_OwnerID",
                table: "Ground");

            migrationBuilder.DropColumn(
                name: "IDOwner",
                table: "Ground");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerID",
                table: "Ground",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ground_Owners_OwnerID",
                table: "Ground",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ground_Owners_OwnerID",
                table: "Ground");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerID",
                table: "Ground",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IDOwner",
                table: "Ground",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Ground_Owners_OwnerID",
                table: "Ground",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

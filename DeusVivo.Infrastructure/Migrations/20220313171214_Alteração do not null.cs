using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeusVivo.Infrastructure.Migrations
{
    public partial class Alteraçãodonotnull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Companhias_CompanhiaId",
                table: "Cargos");

            migrationBuilder.AlterColumn<int>(
                name: "CriacaoId",
                table: "Cargos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanhiaId",
                table: "Cargos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AlteracaoId",
                table: "Cargos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Companhias_CompanhiaId",
                table: "Cargos",
                column: "CompanhiaId",
                principalTable: "Companhias",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cargos_Companhias_CompanhiaId",
                table: "Cargos");

            migrationBuilder.AlterColumn<int>(
                name: "CriacaoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanhiaId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlteracaoId",
                table: "Cargos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cargos_Companhias_CompanhiaId",
                table: "Cargos",
                column: "CompanhiaId",
                principalTable: "Companhias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

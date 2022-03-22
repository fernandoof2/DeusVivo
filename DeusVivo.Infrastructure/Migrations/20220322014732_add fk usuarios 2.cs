using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeusVivo.Infrastructure.Migrations
{
    public partial class addfkusuarios2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlteracaoId",
                table: "Cargos");

            migrationBuilder.DropColumn(
                name: "CriacaoId",
                table: "Cargos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlteracaoId",
                table: "Cargos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CriacaoId",
                table: "Cargos",
                type: "int",
                nullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeusVivo.Infrastructure.Migrations
{
    public partial class addPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PerfilEO_Companhias_CompanhiaId",
                table: "PerfilEO");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilEO_Usuarios_AlteracaoUsuarioId",
                table: "PerfilEO");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilEO_Usuarios_CriacaoUsuarioId",
                table: "PerfilEO");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosPerfis_PerfilEO_PerfilId",
                table: "UsuariosPerfis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PerfilEO",
                table: "PerfilEO");

            migrationBuilder.RenameTable(
                name: "PerfilEO",
                newName: "Perfis");

            migrationBuilder.RenameIndex(
                name: "IX_PerfilEO_CriacaoUsuarioId",
                table: "Perfis",
                newName: "IX_Perfis_CriacaoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_PerfilEO_CompanhiaId",
                table: "Perfis",
                newName: "IX_Perfis_CompanhiaId");

            migrationBuilder.RenameIndex(
                name: "IX_PerfilEO_AlteracaoUsuarioId",
                table: "Perfis",
                newName: "IX_Perfis_AlteracaoUsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfis",
                table: "Perfis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfis_Companhias_CompanhiaId",
                table: "Perfis",
                column: "CompanhiaId",
                principalTable: "Companhias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfis_Usuarios_AlteracaoUsuarioId",
                table: "Perfis",
                column: "AlteracaoUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfis_Usuarios_CriacaoUsuarioId",
                table: "Perfis",
                column: "CriacaoUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosPerfis_Perfis_PerfilId",
                table: "UsuariosPerfis",
                column: "PerfilId",
                principalTable: "Perfis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfis_Companhias_CompanhiaId",
                table: "Perfis");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfis_Usuarios_AlteracaoUsuarioId",
                table: "Perfis");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfis_Usuarios_CriacaoUsuarioId",
                table: "Perfis");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuariosPerfis_Perfis_PerfilId",
                table: "UsuariosPerfis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfis",
                table: "Perfis");

            migrationBuilder.RenameTable(
                name: "Perfis",
                newName: "PerfilEO");

            migrationBuilder.RenameIndex(
                name: "IX_Perfis_CriacaoUsuarioId",
                table: "PerfilEO",
                newName: "IX_PerfilEO_CriacaoUsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Perfis_CompanhiaId",
                table: "PerfilEO",
                newName: "IX_PerfilEO_CompanhiaId");

            migrationBuilder.RenameIndex(
                name: "IX_Perfis_AlteracaoUsuarioId",
                table: "PerfilEO",
                newName: "IX_PerfilEO_AlteracaoUsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PerfilEO",
                table: "PerfilEO",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilEO_Companhias_CompanhiaId",
                table: "PerfilEO",
                column: "CompanhiaId",
                principalTable: "Companhias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilEO_Usuarios_AlteracaoUsuarioId",
                table: "PerfilEO",
                column: "AlteracaoUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilEO_Usuarios_CriacaoUsuarioId",
                table: "PerfilEO",
                column: "CriacaoUsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuariosPerfis_PerfilEO_PerfilId",
                table: "UsuariosPerfis",
                column: "PerfilId",
                principalTable: "PerfilEO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeusVivo.Infrastructure.Migrations
{
    public partial class addUsuariPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PerfilEO",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanhiaId = table.Column<int>(type: "int", nullable: true),
                    CriacaoDataHora = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CriacaoUsuarioId = table.Column<int>(type: "int", nullable: true),
                    AlteracaoDataHora = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AlteracaoUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilEO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PerfilEO_Companhias_CompanhiaId",
                        column: x => x.CompanhiaId,
                        principalTable: "Companhias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerfilEO_Usuarios_AlteracaoUsuarioId",
                        column: x => x.AlteracaoUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PerfilEO_Usuarios_CriacaoUsuarioId",
                        column: x => x.CriacaoUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UsuariosPerfis",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    PerfilId = table.Column<int>(type: "int", nullable: false),
                    CompanhiaId = table.Column<int>(type: "int", nullable: true),
                    CriacaoDataHora = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CriacaoUsuarioId = table.Column<int>(type: "int", nullable: true),
                    AlteracaoDataHora = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    AlteracaoUsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosPerfis", x => new { x.UsuarioId, x.PerfilId });
                    table.ForeignKey(
                        name: "FK_UsuariosPerfis_Companhias_CompanhiaId",
                        column: x => x.CompanhiaId,
                        principalTable: "Companhias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsuariosPerfis_PerfilEO_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "PerfilEO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosPerfis_Usuarios_AlteracaoUsuarioId",
                        column: x => x.AlteracaoUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsuariosPerfis_Usuarios_CriacaoUsuarioId",
                        column: x => x.CriacaoUsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsuariosPerfis_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilEO_AlteracaoUsuarioId",
                table: "PerfilEO",
                column: "AlteracaoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilEO_CompanhiaId",
                table: "PerfilEO",
                column: "CompanhiaId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilEO_CriacaoUsuarioId",
                table: "PerfilEO",
                column: "CriacaoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPerfis_AlteracaoUsuarioId",
                table: "UsuariosPerfis",
                column: "AlteracaoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPerfis_CompanhiaId",
                table: "UsuariosPerfis",
                column: "CompanhiaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPerfis_CriacaoUsuarioId",
                table: "UsuariosPerfis",
                column: "CriacaoUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosPerfis_PerfilId",
                table: "UsuariosPerfis",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosPerfis");

            migrationBuilder.DropTable(
                name: "PerfilEO");
        }
    }
}

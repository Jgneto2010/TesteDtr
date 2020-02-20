using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class projetovale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeUsuario = table.Column<string>(nullable: true),
                    EmailUsuario = table.Column<string>(nullable: true),
                    PasswordUsuario = table.Column<string>(nullable: true),
                    ConfirmaPasswordUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<Guid>(nullable: false),
                    Nome_Produto = table.Column<string>(type: "varchar(40)", nullable: false),
                    Codigo = table.Column<decimal>(type: "decimal", nullable: false),
                    Fabricacao = table.Column<DateTime>(nullable: false),
                    Validade = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal", nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_Produtos_Usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_IdUsuario",
                table: "Produtos",
                column: "IdUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

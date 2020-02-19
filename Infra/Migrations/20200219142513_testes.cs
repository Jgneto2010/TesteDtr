using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class testes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TipoPagamento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeUsuario = table.Column<string>(nullable: true),
                    EmailUsuario = table.Column<string>(nullable: true),
                    PasswordUsuario = table.Column<string>(nullable: true),
                    ConfirmaPasswordUsuario = table.Column<string>(nullable: true),
                    FormaPagamentoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<Guid>(nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: false),
                    Nome_Produto = table.Column<string>(type: "varchar(40)", nullable: false),
                    Codigo = table.Column<decimal>(type: "decimal", nullable: false),
                    Fabricacao = table.Column<DateTime>(nullable: false),
                    Validade = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal", nullable: false),
                    UsuarioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_Produtos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UsuarioId",
                table: "Produtos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_FormaPagamentoId",
                table: "Usuarios",
                column: "FormaPagamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "FormaPagamento");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TesteTecnomyl.Cadastros.Infra.Dados.Migrations
{
    public partial class development : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "municipios",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    uf = table.Column<string>(type: "varchar(2)", nullable: false),
                    nome = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipios", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "produtos",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "varchar(120)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produtos", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    cpf = table.Column<string>(type: "varchar(11)", nullable: false),
                    nome = table.Column<string>(type: "varchar(120)", nullable: false),
                    codigo_municipio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_clientes_municipios_codigo_municipio",
                        column: x => x.codigo_municipio,
                        principalSchema: "public",
                        principalTable: "municipios",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_cliente = table.Column<int>(type: "integer", nullable: false),
                    data_pedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pedidos", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_pedidos_clientes_codigo_cliente",
                        column: x => x.codigo_cliente,
                        principalSchema: "public",
                        principalTable: "clientes",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "itens_pedido",
                schema: "public",
                columns: table => new
                {
                    codigo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    valor = table.Column<decimal>(type: "numeric", nullable: false),
                    quantidade = table.Column<int>(type: "integer", nullable: false),
                    observacao = table.Column<string>(type: "varchar(300)", nullable: false),
                    codigo_produto = table.Column<int>(type: "integer", nullable: false),
                    CodigoPedido = table.Column<int>(type: "integer", nullable: false),
                    ProdutoCodigo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itens_pedido", x => x.codigo);
                    table.ForeignKey(
                        name: "FK_itens_pedido_pedidos_CodigoPedido",
                        column: x => x.CodigoPedido,
                        principalSchema: "public",
                        principalTable: "pedidos",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_itens_pedido_produtos_ProdutoCodigo",
                        column: x => x.ProdutoCodigo,
                        principalSchema: "public",
                        principalTable: "produtos",
                        principalColumn: "codigo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_codigo_municipio",
                schema: "public",
                table: "clientes",
                column: "codigo_municipio");

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_CodigoPedido",
                schema: "public",
                table: "itens_pedido",
                column: "CodigoPedido");

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_ProdutoCodigo",
                schema: "public",
                table: "itens_pedido",
                column: "ProdutoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_codigo_cliente",
                schema: "public",
                table: "pedidos",
                column: "codigo_cliente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itens_pedido",
                schema: "public");

            migrationBuilder.DropTable(
                name: "pedidos",
                schema: "public");

            migrationBuilder.DropTable(
                name: "produtos",
                schema: "public");

            migrationBuilder.DropTable(
                name: "clientes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "municipios",
                schema: "public");
        }
    }
}

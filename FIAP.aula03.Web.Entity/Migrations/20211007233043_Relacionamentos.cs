using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIAP.aula03.Web.Entity.Migrations
{
    public partial class Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_BENEFICIO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Disponivel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_BENEFICIO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_DEPART",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDepart = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DEPART", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIO",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoId = table.Column<int>(type: "int", nullable: true),
                    DepartamentoId = table.Column<int>(type: "int", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: true),
                    DT_CONTRATACAO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIO", x => x.FuncionarioId);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_TB_DEPART_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "TB_DEPART",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_TB_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "TB_ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_FUNCIONARIO_BENEFICIO",
                columns: table => new
                {
                    FuncionarioId = table.Column<int>(type: "int", nullable: false),
                    BeneficioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FUNCIONARIO_BENEFICIO", x => new { x.BeneficioId, x.FuncionarioId });
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_BENEFICIO_TB_BENEFICIO_BeneficioId",
                        column: x => x.BeneficioId,
                        principalTable: "TB_BENEFICIO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_FUNCIONARIO_BENEFICIO_TB_FUNCIONARIO_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "TB_FUNCIONARIO",
                        principalColumn: "FuncionarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_DepartamentoId",
                table: "TB_FUNCIONARIO",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_EnderecoId",
                table: "TB_FUNCIONARIO",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_FUNCIONARIO_BENEFICIO_FuncionarioId",
                table: "TB_FUNCIONARIO_BENEFICIO",
                column: "FuncionarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIO_BENEFICIO");

            migrationBuilder.DropTable(
                name: "TB_BENEFICIO");

            migrationBuilder.DropTable(
                name: "TB_FUNCIONARIO");

            migrationBuilder.DropTable(
                name: "TB_DEPART");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO");
        }
    }
}

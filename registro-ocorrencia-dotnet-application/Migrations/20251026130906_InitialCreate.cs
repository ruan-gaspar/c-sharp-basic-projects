using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace registro_ocorrencia_dotnet_application.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AGENTE_RESPONSAVEL",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cargo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGENTE_RESPONSAVEL", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DELEGACIA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DelegadoResponsavel = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DELEGACIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NOTICIANTE",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Rg = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOTICIANTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OCORRENCIA",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataRegistro = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    NumeroOcorrencia = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CodigoOcorrencia = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    LocalOcorrencia = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    StatusConcluido = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Categoria = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCORRENCIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TERCEIROS",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "RAW(16)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cpf = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Rg = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Idade = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TERCEIROS", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AGENTE_RESPONSAVEL");

            migrationBuilder.DropTable(
                name: "DELEGACIA");

            migrationBuilder.DropTable(
                name: "NOTICIANTE");

            migrationBuilder.DropTable(
                name: "OCORRENCIA");

            migrationBuilder.DropTable(
                name: "TERCEIROS");
        }
    }
}

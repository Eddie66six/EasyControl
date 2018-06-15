using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyControl.Repositorio.Migrations
{
    public partial class AddProductReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "Pacientes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFilial",
                table: "Medicos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmpresaIdEmpresa",
                table: "Convenios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFilial",
                table: "Convenios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdFilial",
                table: "Colaboradores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Filiais",
                columns: table => new
                {
                    IdFilial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiais", x => x.IdFilial);
                    table.ForeignKey(
                        name: "FK_Filiais_Empresas_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_IdEmpresa",
                table: "Pacientes",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_IdFilial",
                table: "Medicos",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Convenios_EmpresaIdEmpresa",
                table: "Convenios",
                column: "EmpresaIdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_IdFilial",
                table: "Colaboradores",
                column: "IdFilial");

            migrationBuilder.CreateIndex(
                name: "IX_Filiais_IdEmpresa",
                table: "Filiais",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Filiais_IdFilial",
                table: "Colaboradores",
                column: "IdFilial",
                principalTable: "Filiais",
                principalColumn: "IdFilial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Convenios_Empresas_EmpresaIdEmpresa",
                table: "Convenios",
                column: "EmpresaIdEmpresa",
                principalTable: "Empresas",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicos_Filiais_IdFilial",
                table: "Medicos",
                column: "IdFilial",
                principalTable: "Filiais",
                principalColumn: "IdFilial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Empresas_IdEmpresa",
                table: "Pacientes",
                column: "IdEmpresa",
                principalTable: "Empresas",
                principalColumn: "IdEmpresa",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Filiais_IdFilial",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Convenios_Empresas_EmpresaIdEmpresa",
                table: "Convenios");

            migrationBuilder.DropForeignKey(
                name: "FK_Medicos_Filiais_IdFilial",
                table: "Medicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Empresas_IdEmpresa",
                table: "Pacientes");

            migrationBuilder.DropTable(
                name: "Filiais");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_IdEmpresa",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Medicos_IdFilial",
                table: "Medicos");

            migrationBuilder.DropIndex(
                name: "IX_Convenios_EmpresaIdEmpresa",
                table: "Convenios");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_IdFilial",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "IdFilial",
                table: "Medicos");

            migrationBuilder.DropColumn(
                name: "EmpresaIdEmpresa",
                table: "Convenios");

            migrationBuilder.DropColumn(
                name: "IdFilial",
                table: "Convenios");

            migrationBuilder.DropColumn(
                name: "IdFilial",
                table: "Colaboradores");
        }
    }
}

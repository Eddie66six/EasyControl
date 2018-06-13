using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyControl.Repositorio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    IdColaborador = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.IdColaborador);
                });

            migrationBuilder.CreateTable(
                name: "Convenios",
                columns: table => new
                {
                    IdConvenio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenios", x => x.IdConvenio);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    IdMedico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.IdMedico);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    IdPermissao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(maxLength: 50, nullable: true),
                    IdFuncionario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.IdPermissao);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    Sobrenome = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    IdPaciente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConvenioIdConvenio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.IdPaciente);
                    table.ForeignKey(
                        name: "FK_Paciente_Convenios_ConvenioIdConvenio",
                        column: x => x.ConvenioIdConvenio,
                        principalTable: "Convenios",
                        principalColumn: "IdConvenio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConvenioCredenciado",
                columns: table => new
                {
                    IdMedico = table.Column<int>(nullable: false),
                    IdConveio = table.Column<int>(nullable: false),
                    ConvenioIdConvenio = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvenioCredenciado", x => new { x.IdMedico, x.IdConveio });
                    table.ForeignKey(
                        name: "FK_ConvenioCredenciado_Convenios_ConvenioIdConvenio",
                        column: x => x.ConvenioIdConvenio,
                        principalTable: "Convenios",
                        principalColumn: "IdConvenio",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConvenioCredenciado_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Especialidade",
                columns: table => new
                {
                    IdEspecialidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    IdMedico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidade", x => x.IdEspecialidade);
                    table.ForeignKey(
                        name: "FK_Especialidade_Medico_IdMedico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "IdMedico",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColaboradorPermissao",
                columns: table => new
                {
                    IdColaborador = table.Column<int>(nullable: false),
                    IdPermissao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColaboradorPermissao", x => new { x.IdColaborador, x.IdPermissao });
                    table.ForeignKey(
                        name: "FK_ColaboradorPermissao_Colaborador_IdColaborador",
                        column: x => x.IdColaborador,
                        principalTable: "Colaborador",
                        principalColumn: "IdColaborador",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColaboradorPermissao_Permissao_IdPermissao",
                        column: x => x.IdPermissao,
                        principalTable: "Permissao",
                        principalColumn: "IdPermissao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedimento",
                columns: table => new
                {
                    IdProcedimento = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: true),
                    IdEspecialidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EspecialidadeIdEspecialidade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimento", x => x.IdEspecialidade);
                    table.ForeignKey(
                        name: "FK_Procedimento_Especialidade_EspecialidadeIdEspecialidade",
                        column: x => x.EspecialidadeIdEspecialidade,
                        principalTable: "Especialidade",
                        principalColumn: "IdEspecialidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColaboradorPermissao_IdPermissao",
                table: "ColaboradorPermissao",
                column: "IdPermissao");

            migrationBuilder.CreateIndex(
                name: "IX_ConvenioCredenciado_ConvenioIdConvenio",
                table: "ConvenioCredenciado",
                column: "ConvenioIdConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_Especialidade_IdMedico",
                table: "Especialidade",
                column: "IdMedico");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_ConvenioIdConvenio",
                table: "Paciente",
                column: "ConvenioIdConvenio");

            migrationBuilder.CreateIndex(
                name: "IX_Procedimento_EspecialidadeIdEspecialidade",
                table: "Procedimento",
                column: "EspecialidadeIdEspecialidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColaboradorPermissao");

            migrationBuilder.DropTable(
                name: "ConvenioCredenciado");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Procedimento");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "Convenios");

            migrationBuilder.DropTable(
                name: "Especialidade");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}

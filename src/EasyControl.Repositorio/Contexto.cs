using EasyControl.Dominio.Convenio.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Medico.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Entidade;
using EasyControl.Dominio.Pessoa.Paciente.Entidade;
using EasyControl.Repositorio.Map.Convenio;
using EasyControl.Repositorio.Map.Pessoa.Funcionario;
using EasyControl.Repositorio.Map.Pessoa.Funcionario.Colaborador;
using EasyControl.Repositorio.Map.Pessoa.Funcionario.Medico;
using EasyControl.Repositorio.Map.Pessoa.Paciente;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using EasyControl.Dominio.Pessoa;
using EasyControl.Dominio.Empresa.Entidade;
using EasyControl.Repositorio.Map.Empresa;

namespace EasyControl.Repositorio
{
    //primeira vez
    //Add-Migration InitialCreate -> Update-Database
    //atualizar
    //Add-Migration AddProductReviews -> Update-Database
    //remover
    //Remove-Migration
    //reverter
    //Update-Database LastGoodMigration
    public class Contexto : DbContext
    {
        public Contexto()
        {

        }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Filial> Filiais { get; set; }

        //N:N
        public DbSet<ConvenioCredenciado> ConveniosCredenciados { get; set; }
        public DbSet<ColaboradorPermissao> ColaboradorPermissoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Ignore<Pessoa>();
            modelBuilder.Ignore<Funcionario>();
            //N:N
            modelBuilder.Entity<ConvenioCredenciado>()
                .HasKey(t => new { t.IdMedico, t.IdConveio });
            modelBuilder.Entity<ColaboradorPermissao>()
                .HasKey(t => new { t.IdColaborador, t.IdPermissao });

            //geral
            modelBuilder.ApplyConfiguration(new MedicoMap());
            modelBuilder.ApplyConfiguration(new ConvenioMap());
            modelBuilder.ApplyConfiguration(new EspecialidadeMap());
            modelBuilder.ApplyConfiguration(new ProcedimentoMap());
            modelBuilder.ApplyConfiguration(new PermissaoMap());
            modelBuilder.ApplyConfiguration(new PacienteMap());
            modelBuilder.ApplyConfiguration(new ColaboradorMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new FilialMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // define the database to use
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EasyControlDb;Integrated Security=true");
        }
    }

    public class GerenciadorContexto
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GerenciadorContexto(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Contexto GetContext()
        {
            if (_httpContextAccessor.HttpContext.Items["ContextManager.Context"] == null)
            {

                _httpContextAccessor.HttpContext.Items["ContextManager.Context"] = new Contexto();
            }

            return (Contexto)_httpContextAccessor.HttpContext.Items["ContextManager.Context"];
        }
    }
}

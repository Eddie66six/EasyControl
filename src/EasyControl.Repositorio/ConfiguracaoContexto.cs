﻿using EasyControl.Dominio.Convenio._1.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Colaborador._1.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade;
using EasyControl.Dominio.Pessoa.Funcionario._1.Entidade;
using EasyControl.Dominio.Pessoa.Paciente._1.Entidade;
using EasyControl.Dominio.Pessoa._1.Entidade;
using EasyControl.Repositorio.Map.Convenio;
using EasyControl.Repositorio.Map.Pessoa.Funcionario;
using EasyControl.Repositorio.Map.Pessoa.Funcionario.Colaborador;
using EasyControl.Repositorio.Map.Pessoa.Funcionario.Medico;
using EasyControl.Repositorio.Map.Pessoa.Paciente;
using Microsoft.EntityFrameworkCore;

namespace EasyControl.Repositorio
{
    public class ConfiguracaoContexto : DbContext
    {
        public ConfiguracaoContexto(DbContextOptions<ConfiguracaoContexto> options)
            : base(options)
        { }

        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Convenio> Convenios { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Permissao> Permissoes { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }

        //N:N
        public DbSet<ConvenioCredenciado> ConveniosCredenciados{ get; set; }
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
        }
    }
}
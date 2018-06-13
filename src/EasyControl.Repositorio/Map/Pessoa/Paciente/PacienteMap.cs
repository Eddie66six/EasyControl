using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Paciente
{
    public class PacienteMap : IEntityTypeConfiguration<Dominio.Pessoa.Paciente._1.Entidade.Paciente>
    {
        public void Configure(EntityTypeBuilder<Dominio.Pessoa.Paciente._1.Entidade.Paciente> builder)
        {
            builder.HasKey(u => u.IdPaciente);
            builder.Property(u => u.Nome).HasMaxLength(50);
        }
    }
}

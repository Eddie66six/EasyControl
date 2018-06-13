using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Funcionario.Medico
{
    public class MedicoMap : IEntityTypeConfiguration<Dominio.Pessoa.Funcionario.Medico._1.Entidade.Medico>
    {
        public void Configure(EntityTypeBuilder<Dominio.Pessoa.Funcionario.Medico._1.Entidade.Medico> builder)
        {
            builder.HasKey(p => p.IdMedico);
            builder.Property(u => u.Nome).HasMaxLength(50);

            builder.HasMany(p => p.Especialidades)
                .WithOne(b => b.Medico);
            builder.HasMany(p => p.ConveniosCredenciados)
                .WithOne(b => b.Medico);
        }
    }
}

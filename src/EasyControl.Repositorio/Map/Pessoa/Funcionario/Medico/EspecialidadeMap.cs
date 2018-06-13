using EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Funcionario.Medico
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(u => u.IdEspecialidade);
            builder.Property(u => u.Nome).HasMaxLength(50);

            builder.HasMany(p => p.Procedimentos)
                .WithOne(b => b.Especialidade);
        }
    }
}

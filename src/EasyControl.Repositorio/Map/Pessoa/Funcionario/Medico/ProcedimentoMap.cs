using EasyControl.Dominio.Pessoa.Funcionario.Medico._1.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Funcionario.Medico
{
    public class ProcedimentoMap : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.HasKey(u => u.IdEspecialidade);
            builder.Property(u => u.Nome).HasMaxLength(50);
        }
    }
}

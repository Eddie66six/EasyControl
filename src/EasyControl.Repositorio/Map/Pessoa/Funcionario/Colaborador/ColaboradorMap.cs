using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Funcionario.Colaborador
{
    public class ColaboradorMap : IEntityTypeConfiguration<Dominio.Pessoa.Funcionario.Colaborador._1.Entidade.Colaborador>
    {
        public void Configure(EntityTypeBuilder<Dominio.Pessoa.Funcionario.Colaborador._1.Entidade.Colaborador> builder)
        {
            builder.HasKey(p => p.IdColaborador);
            builder.Property(u => u.Nome).HasMaxLength(50);
        }
    }
}

using EasyControl.Dominio.Pessoa.Funcionario.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Pessoa.Funcionario
{
    public class PermissaoMap : IEntityTypeConfiguration<Permissao>
    {
        public void Configure(EntityTypeBuilder<Permissao> builder)
        {
            builder.HasKey(u => u.IdPermissao);
            builder.Property(u => u.Key).HasMaxLength(50);

            builder.HasMany(p => p.Colaboradores)
                .WithOne(b => b.Permissao);
        }
    }
}

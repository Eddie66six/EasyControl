using EasyControl.Dominio.Empresa.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyControl.Repositorio.Map.Empresa
{
    public class FilialMap : IEntityTypeConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasKey(p => p.IdFilial);
            builder.Property(u => u.Nome).HasMaxLength(50);

            builder.HasMany(p => p.Colaboradores)
                .WithOne(b => b.Filial);
            builder.HasMany(p => p.Medicos)
                .WithOne(b => b.Filial);
        }
    }
}

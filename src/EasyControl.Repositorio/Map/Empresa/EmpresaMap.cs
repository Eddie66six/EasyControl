using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EasyControl.Repositorio.Map.Empresa
{
    public class EmpresaMap : IEntityTypeConfiguration<Dominio.Empresa.Entidade.Empresa>
    {
        public void Configure(EntityTypeBuilder<Dominio.Empresa.Entidade.Empresa> builder)
        {
            builder.HasKey(p => p.IdEmpresa);
            builder.Property(u => u.Nome).HasMaxLength(50);

            builder.HasMany(p => p.Filiais)
                .WithOne(b => b.Empresa);
            builder.HasMany(p => p.Pacientes)
                .WithOne(b => b.Empresa);
            builder.HasMany(p => p.Convenios)
                .WithOne(b => b.Empresa);
        }
    }
}

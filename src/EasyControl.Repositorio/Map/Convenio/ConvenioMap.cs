using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EasyControl.Repositorio.Map.Convenio
{
    public class ConvenioMap : IEntityTypeConfiguration<Dominio.Convenio._1.Entidade.Convenio>
    {
        public void Configure(EntityTypeBuilder<Dominio.Convenio._1.Entidade.Convenio> builder)
        {
            // Override nvarchar(max) with nvarchar(15)
            builder.HasKey(u => u.IdConvenio);
            builder.Property(u => u.Nome).HasMaxLength(50);

            builder.HasMany(p => p.Pacientes)
                .WithOne(b => b.Convenio);

            builder.HasMany(p => p.MedicosCredenciados)
                .WithOne(b => b.Convenio);

            // Make the default table name of AspNetUsers to Users
            //builder.ToTable("Users");
        }
    }
}

using Dominio.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Maps
{
    public class MapeamentoUsuario : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(e => e.Name)
                   .HasColumnType("varchar(150)")
                   .IsRequired();

            builder.HasMany(c => c.Products)
                    .WithOne(e => e.Category);

            builder.Ignore(e => e.ValidationResult);
            builder.Ignore(e => e.CascadeMode);
            builder.ToTable("Categories");
        }
    }
}

using Dominio.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Maps
{
    public class MapeamentoUsuario
    {
        public class Mapeamento : IEntityTypeConfiguration<Usuario>
        {
            public void Configure(EntityTypeBuilder<Usuario> builder)
            {
                builder.Property(e => e.Id)
                       .HasColumnType("Int")
                       .IsRequired();

                builder.Property(e => e.NomeUsuario)
                       .HasColumnType("varchar(40)")
                       .IsRequired();

                builder.Property(e => e.EmailUsuario)
                       .HasColumnType("string")
                       .IsRequired();

                builder.Property(e => e.PasswordUsuario)
                       .HasColumnType("string")
                       .IsRequired();

                
            }
        }
    }
}

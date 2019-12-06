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
            builder.Property(e => e.Id)
                   .HasColumnType("varchar(40)")
                   .IsRequired();

            builder.Property(e => e.NomeUsuario)
                   .HasColumnType("String(50)")
                   .IsRequired();

            builder.Property(e => e.PasswordUsuario)
                   .HasColumnType("String")
                   .IsRequired();

            builder.Property(e => e.EnderecoUsuario)
                   .HasColumnType("String(30)")
                   .IsRequired();

            builder.Property(e => e.EmailUsuario)
                   .HasColumnType("String(30)")
                   .IsRequired();


            
        }
    }
}

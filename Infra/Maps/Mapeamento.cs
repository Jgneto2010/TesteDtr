using Dominio.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Maps
{
    public class Mapeamento : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            
            builder.Property(e => e.Id)
                   .HasColumnType("Int")
                   .IsRequired();
            
            builder.Property(e => e.NomeProduto)
                   .HasColumnType("varchar(40)")
                   .IsRequired();
           
            builder.Property(e => e.Codigo)
                   .HasColumnType("decimal")
                   .IsRequired();
           
            builder.Property(e => e.Preco)
                   .HasColumnType("decimal")
                   .IsRequired();

            builder.Property(e => e.Validade)
                   .HasColumnType("DateTime")
                   .IsRequired();
            
        }
    }
}

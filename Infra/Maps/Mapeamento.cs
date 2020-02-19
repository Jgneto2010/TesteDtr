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

            builder.HasKey(x => x.Id);

            builder.Property(e => e.Id)
                  .HasColumnName("ID_PRODUTO");
                   
            
            builder.Property(e => e.NomeProduto)
                   .HasColumnName("Nome_Produto")
                   .HasColumnType("varchar(40)")
                   .IsRequired();
           
            builder.Property(e => e.Codigo)
                  .HasColumnName("Codigo")
                   .HasColumnType("decimal")
                   .IsRequired();
           
            builder.Property(e => e.Preco)
                   .HasColumnName("Preco")
                   .HasColumnType("decimal")
                   .IsRequired();

            builder.Property(e => e.Validade)
                   .HasColumnName("Validade")
                   .HasColumnType("DateTime")
                   .IsRequired();
            
        }
    }
}

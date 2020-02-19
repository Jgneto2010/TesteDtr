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
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Id)
                    .HasColumnName("ID_SERVICO");
                

                builder.Property(e => e.NomeUsuario)
                      .HasColumnName("NomeUsuario")
                       .HasColumnType("varchar(40)")
                       .IsRequired();

                builder.Property(e => e.EmailUsuario)
                       .HasColumnName("EmailUsuario")
                       .HasColumnType("string")
                       .IsRequired();

                builder.Property(e => e.PasswordUsuario)
                      .HasColumnName("PasswordUsuario")
                       .HasColumnType("string")
                       .IsRequired();

                //Aqui Foi Criado um relacionamento entre o usuario e o produto
                //builder.HasOne(e => e.Usuario)
                //.WithMany(e => e.Produto)
                //.HasForeignKey(e => e.IdUsuario)
                //.IsRequired();

            }
        }
    }
}

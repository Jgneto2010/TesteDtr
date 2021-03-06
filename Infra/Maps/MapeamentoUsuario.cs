﻿using Dominio.Modelo.Entidades;
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

                builder.Property(e => e.Id)
                      .HasColumnName("ID_USUARIO");


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

               // Aqui Foi Criado um relacionamento entre o usuario e o produto
                builder.HasMany(e => e.ColecaoProdutos)
                .WithOne(e => e.usuario)
                .HasForeignKey(e => e.IdUsuario)
                .IsRequired();

            }
        }
    }
}

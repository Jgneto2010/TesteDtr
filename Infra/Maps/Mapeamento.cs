﻿using Dominio.Modelo.Entidades;
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
           
            builder.Property(e => e.CodigoProduto)
                   .HasColumnType("decimal")
                   .IsRequired();
           
            builder.Property(e => e.PrecoProduto)
                   .HasColumnType("decimal")
                   .IsRequired();

            builder.Property(e => e.ValidadeProduto)
                   .HasColumnType("DateTime")
                   .IsRequired();
            //Aqui Foi Criado um relacionamento entre a Aplicação e os serviços
            builder.HasOne(e => e.Usuario)
            .WithMany(e => e.Servicos)
            .HasForeignKey(e => e.IdUsuario)
            .IsRequired();
        }
    }
}

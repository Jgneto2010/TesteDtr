﻿// <auto-generated />
using System;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200220120659_projetovale")]
    partial class projetovale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dominio.Modelo.Entidades.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID_PRODUTO");

                    b.Property<decimal>("Codigo")
                        .HasColumnName("Codigo")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("Fabricacao");

                    b.Property<Guid>("IdUsuario");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnName("Nome_Produto")
                        .HasColumnType("varchar(40)");

                    b.Property<decimal>("Preco")
                        .HasColumnName("Preco")
                        .HasColumnType("decimal");

                    b.Property<DateTime>("Validade")
                        .HasColumnName("Validade")
                        .HasColumnType("DateTime");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Dominio.Modelo.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmaPasswordUsuario");

                    b.Property<string>("EmailUsuario");

                    b.Property<string>("NomeUsuario");

                    b.Property<string>("PasswordUsuario");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Dominio.Modelo.Entidades.Produto", b =>
                {
                    b.HasOne("Dominio.Modelo.Entidades.Usuario", "usuario")
                        .WithMany("ColecaoProdutos")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

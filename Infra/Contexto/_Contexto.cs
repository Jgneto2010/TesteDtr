using Dominio.Modelo.Entidades;
using Infra.Maps;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infra.Contexto
{
    public class _Contexto : DbContext
    {
        public DbSet<Produto> Prod { get; set; }
        public DbSet<Usuario> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(Runtime.ConnectionString);
        }

        

    }
}

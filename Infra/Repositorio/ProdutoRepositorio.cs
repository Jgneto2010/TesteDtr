using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public class ProdutoRepositorio : Repository<Produto>, ICategoryRepository
        {
            public ProdutoRepositorio(Contextos.Contexto context) : base(context)
            {
            }
        }

    }
}

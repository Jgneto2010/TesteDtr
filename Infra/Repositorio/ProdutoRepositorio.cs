using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Infra.Contexto;
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
            public ProdutoRepositorio(_Contexto context) : base(context)
            {
            }
        }

    }
}

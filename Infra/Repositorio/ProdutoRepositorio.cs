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
        public ProdutoRepositorio(_Contexto context): base(context)
        {
        }

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProductsCategories()
        {
            return Db.Products.Include(c => c.Category).ToList();
        }

    }
}

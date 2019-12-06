using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos.Interfaces
{
    public interface IProdutoRepositorio
    {
        public interface IProductRepository : IRepository<Produto>
        {
            IEnumerable<Produto> GetAllProductsCategories();
            void AddCategory(Category category);
        }
    }
}

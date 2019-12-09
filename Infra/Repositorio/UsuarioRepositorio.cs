using Dominio.Modelo.Entidades;
using Infra.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Repositorio
{
    public class UsuarioRepositorio
    {
        private readonly Contexto _contexto;
        public UsuarioRepositorio(Contexto contexto)
        {
            _contexto = contexto;
        }
        public void Add(Usuario obj)
        {
            _contexto.Usuarios.Add(obj);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuarios.ToList();
        }

        public Produto GetById(int id)
        {
            return _contexto.Produtos.Where(c => c.Id == id).First();
        }


        public Produto ObterProdutoPeloNome(string nome)
        {
            return _contexto.Produtos.Where(c => c.NomeProduto == nome).First();
        }

        public void Remove(int id)
        {
            var produto = GetById(id);
            _contexto.Produtos.Remove(produto);
        }

        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public void UpDate(Produto obj)
        {
            _contexto.Produtos.Update(obj);
        }
    }
}

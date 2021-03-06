﻿using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IRepositorio<Produto>, IProdutoRepositorio
    {
        private readonly Contexto _contexto;
        public ProdutoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public void Add(Produto obj)
        {
            _contexto.Produtos.Add(obj);
        }

        public IEnumerable<Produto> GetAll()
        {
            return _contexto.Produtos.ToList();
        }

        public Produto GetById(Guid id)
        {
            return _contexto.Produtos.Where(c => c.Id == id).First();
        }

        public Produto ObterProdutoPeloNome(string nome)
        {
            return _contexto.Produtos.Where(c => c.NomeProduto == nome).First();
        }

        public Produto ObterPeloId(Guid id)
        {
            throw new NotImplementedException();
        }

       
        public int SaveChanges()
        {
            return _contexto.SaveChanges();
        }

        public void UpDate(Produto obj)
        {
            _contexto.Produtos.Update(obj);
        }

        public Task<Produto> GetByName(string nomeAplicacao)
        {
            throw new NotImplementedException();
        }
    }
}

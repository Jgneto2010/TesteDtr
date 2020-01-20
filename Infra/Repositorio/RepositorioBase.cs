using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Infra.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public abstract class RepositorioBase<T> : IRepositorio<T>
        where T : Entity
    {
        private readonly Contexto _contexto;
        protected readonly DbSet<T> DbSet;
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
            DbSet = _contexto.Set<T>();
        }
        
        public Task<List<T>> GetAll()
        {
            return DbSet.ToListAsync();
        }
        public Task<T> GetById(Guid id)
        {
            return DbSet.Where(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task Remove(Guid id)
        {
            var aplicacao = await GetById(id);
            DbSet.Remove(aplicacao);
        }
        public Task<int> SaveChanges()
        {
            return _contexto.SaveChangesAsync();
        }
        public void Update(T obj)
        {
            DbSet.Update(obj);
        }

        void IRepositorio<T>.Add(T obj)
        {
            throw new NotImplementedException();
        }

        T IRepositorio<T>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<T> IRepositorio<T>.GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpDate(T obj)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<T>.Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        int IRepositorio<T>.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

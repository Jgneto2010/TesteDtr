using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Contratos.Interfaces
{
    public interface IRepositorio<T>
        where T : Entity
    {
        void Add(T obj);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
        void UpDate(T obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}

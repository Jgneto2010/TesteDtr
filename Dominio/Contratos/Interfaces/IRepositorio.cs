using System;
using System.Collections.Generic;

namespace Dominio.Contratos.Interfaces
{
    public interface IRepositorio<T>
    {
        void Add(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void UpDate(T obj);
        void Remove(int id);
        int SaveChanges();
    }
}

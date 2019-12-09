using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Produto ObterUsuarioPeloId(int Id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string NomeUsuario { get; private set; }
        public string EmailUsuario { get; private set; }
        public string PasswordUsuario { get; private set; }
        public string ConfirmaPasswordUsuario { get; private set; }
        public List<Produto> ProdutosUsuario { get; private set; }
    }
}

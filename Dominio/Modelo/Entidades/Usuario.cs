using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Usuario : Entity
    {
        public Usuario() { }

        public Guid IdUsuario { get; set; }
        public string NomeUsuario { get;  set; }
        public string EmailUsuario { get;  set; }
        public string PasswordUsuario { get;  set; }
        public string ConfirmaPasswordUsuario { get;  set; }
        public List<Produto> ColecaoProdutos { get; set; }
        public Produto produto { get; set; }
    }
}

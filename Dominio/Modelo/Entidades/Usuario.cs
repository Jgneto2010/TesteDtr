using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Usuario : Entity
    {
        public Usuario(string email, string nomeusuario, string password)
        {
            NomeUsuario = nomeusuario;
            EmailUsuario = email;
            Id = Guid.NewGuid();
        }
        public Usuario() { }
        public string NomeUsuario { get;  set; }
        public string EmailUsuario { get;  set; }
        public string PasswordUsuario { get;  set; }
        public string ConfirmaPasswordUsuario { get;  set; }
        public List<Produto> ColecaoProdutos { get; set; }
    }
}

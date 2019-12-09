using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto
    {
        public int Id { get; private set; }
        public string NomeProduto { get; private set; }
        public decimal CodigoProduto { get; private set; }
        public DateTime ValidadeProduto { get; private set; }
        public decimal PrecoProduto { get; private set; }
        public List<Usuario> ListaUsuarios { get; private set; }
    }
}


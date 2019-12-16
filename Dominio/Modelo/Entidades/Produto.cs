using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto : Entity
    {
        public Produto() { }
        public string NomeProduto { get;  set; }
        public decimal CodigoProduto { get;  set; }
        public DateTime ValidadeProduto { get;  set; }
        public decimal PrecoProduto { get;  set; }
        public Usuario Usuario { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public decimal CodigoProduto { get; set; }
        public DateTime ValidadeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
    }
}


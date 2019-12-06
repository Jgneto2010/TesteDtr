using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto
    {
        public Produto(decimal codigoProduto)
        {
            CodigoProduto = codigoProduto;
        }
        
        public int Id { get; protected set; }
        public string NomeProduto { get; protected set; }
        public decimal CodigoProduto { get; protected set; }
        public DateTime ValidadeProduto { get; protected set; }
        public char PrecoProduto { get; protected set; }
    }
}


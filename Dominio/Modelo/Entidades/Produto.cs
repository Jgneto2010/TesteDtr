using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto : Entity
    {
        public Produto(string nome, int codigo, DateTime validade, decimal preco)
        {
            NomeProduto = nome;
            Codigo = codigo;
            Validade = validade;
            Preco = preco;
        }


        public string NomeProduto { get;  set; }
        public int Codigo { get;  set; }
        public DateTime Validade { get;  set; }
        public decimal Preco { get;  set; }
        public Usuario Usuario { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto : Entity
    {
        public Produto(string nome, int codigo, DateTime fabricacao, decimal preco, DateTime validade)
        {
            NomeProduto = nome;
            Codigo = codigo;
            Fabricacao = fabricacao;
            Preco = preco;
            Validade = validade;
        }
        public Guid IdUsuario { get; set; }
        public string NomeProduto { get;  set; }
        public int Codigo { get;  set; }
        public DateTime Fabricacao { get;  set; }
        public DateTime Validade { get; set; }
        public decimal Preco { get;  set; }
        public Usuario Usuario { get; set; }
    }
}


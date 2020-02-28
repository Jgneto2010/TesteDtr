using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Produto : Entity
    {
        public Produto(string nomeproduto, int codigoProduto, decimal precoProduto, DateTime fabricacaoProduto, DateTime validade)
        {
            NomeProduto = nomeproduto;
            Codigo = codigoProduto;
            Preco = precoProduto;
            Fabricacao = fabricacaoProduto;
            Validade = validade;
            Id = Guid.NewGuid();
        }
        public Produto(){ }
        public string NomeProduto { get;  set; }
        public int Codigo { get;  set; }
        public DateTime Fabricacao { get;  set; }
        public DateTime Validade { get;  set; }
        public decimal Preco { get;  set; }
        public Guid? IdUsuario { get; set; }
        public Usuario usuario { get; set; }
        
    }
}


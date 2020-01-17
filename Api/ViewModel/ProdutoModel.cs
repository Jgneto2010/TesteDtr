using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class ProdutoModel
    {
        public ProdutoModel(string nome, int codigo, DateTime fabricacao, decimal preco, DateTime validade )
        {
            NomeProduto = nome;
            Codigo = codigo;
            Fabricacao = fabricacao;
            Preco = preco;
            Validade = validade;
        }

        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public DateTime Fabricacao { get; set; }
        public DateTime Validade { get; set; }
        public decimal Preco { get; set; }
        public Usuario Usuario { get; set; }
    }
}

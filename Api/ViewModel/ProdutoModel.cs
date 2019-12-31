using Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class ProdutoModel
    {
        public ProdutoModel(string nome, int codigo, DateTime validade, decimal preco )
        {
            NomeProduto = nome;
            Codigo = codigo;
            Validade = validade;
            Preco = preco;
        }

        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public DateTime Validade { get; set; }
        public decimal Preco { get; set; }
        public Usuario Usuario { get; set; }
    }
}

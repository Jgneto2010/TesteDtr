using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class AddProdutoModel
    {
        public string NomeProduto { get; set; }
        public int Codigo { get; set; }
        public DateTime Fabricacao { get; set; }
        public DateTime Validade { get; set; }
        public decimal Preco { get; set; }
        
    }
}

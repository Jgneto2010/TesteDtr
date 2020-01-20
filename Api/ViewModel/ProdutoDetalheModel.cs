using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class ProdutoDetalheModel
    {
        public string NomeProduto { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime Fabricacao { get; set; }
        public DateTime Validade { get; set; }
        public decimal PrecoProduto { get; set; }
        public UsuarioDetalheModel Usuario { get; set; }
    }
}

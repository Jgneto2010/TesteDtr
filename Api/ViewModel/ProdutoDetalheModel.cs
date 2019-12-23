using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class ProdutoDetalheModel
    {
        public string NomeProduto { get; set; }
        public decimal CodigoProduto { get; set; }
        public DateTime ValidadeProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public UsuarioDetalheModel Usuario { get; set; }
    }
}

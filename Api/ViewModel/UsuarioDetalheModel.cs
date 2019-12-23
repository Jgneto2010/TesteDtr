using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class UsuarioDetalheModel
    {
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public string ConfirmaPasswordUsuario { get; set; }
        public ICollection<ProdutoDetalheModel> ColecaoProdutos { get; set; }
        
    }
}

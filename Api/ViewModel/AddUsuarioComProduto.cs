﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class AddUsuarioComProduto
    {
        public string NomeUsuario { get; set; }
        public List<ProdutoDetalheModel> ColecaoProdutos { get; set; }

    }
}

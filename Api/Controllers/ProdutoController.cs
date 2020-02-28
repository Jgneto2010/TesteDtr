using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.ViewModel;
using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Dominio.Validacoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        [Route("cadastrarProdutos")]
        public async Task<IActionResult> CadastrarProduto([FromServices]IProdutoRepositorio repositorio, [FromBody]AddProduto produtoModel)
        {
            var prod = new Produto
            { NomeProduto = produtoModel.NomeProduto,
                Codigo = produtoModel.Codigo,
                Preco = produtoModel.Preco,
                Fabricacao = produtoModel.Fabricacao = DateTime.Now,
                Validade = produtoModel.Validade = DateTime.Now.AddMonths(3)
            }; 

            repositorio.Add(prod);
            repositorio.SaveChanges();
            return Created($"api/produto/{prod.NomeProduto}", new { prod.Id, prod.usuario, prod.Fabricacao, prod.Validade });
        }
        

    }
}
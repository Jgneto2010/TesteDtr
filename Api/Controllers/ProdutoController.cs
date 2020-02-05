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
        [Route("addProduto")]
        public async Task<IActionResult> PostCadastrarProduto([FromServices]IProdutoRepositorio repositorio, [FromBody]AddProdutoModel produtoModel)
        {
            var produto = new Produto(produtoModel.NomeProduto, produtoModel.Codigo, produtoModel.Fabricacao = DateTime.Now, produtoModel.Preco, produtoModel.Validade);
            var validacao = new ProdutoValidator().Validate(produto);

            produto.Fabricacao = DateTime.Now;
            produto.Validade = DateTime.Now.AddMonths(1);
            ////TimeSpan diferenca = produto.Fabricacao.Subtract(produto.Validade);
            //double dias = diferenca.TotalDays;
            
            repositorio.Add(produto);
            repositorio.SaveChanges();
            return Created($"api/produto/{produto.NomeProduto}", new { produto.Id, produto.Fabricacao, produto.Validade });
        }

        [HttpGet]
        [Route("getProduto")]
        public async Task<IActionResult> GetProdutoNome([FromServices] IProdutoRepositorio repositorio, [FromBody] string nomeProduto)
        {
            var result = await repositorio.GetByName(nomeProduto);

            if (result == default)
                return NotFound();

            return Ok(new ProdutoModel
            {
                NomeProduto = result.NomeProduto,
                Codigo = result.Codigo,
                Fabricacao = result.Fabricacao,
                Preco = result.Preco,
                Validade = result.Validade

            }) ;

        }

    }
}
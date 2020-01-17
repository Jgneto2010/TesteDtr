using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.ViewModel;
using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
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
        public async Task<IActionResult> AdicionandoProdutoEstoque([FromServices]IProdutoRepositorio repositorio, [FromBody]AddProdutoModel addProdutoModel)
        {
            var produto = new Produto(addProdutoModel.NomeProduto, addProdutoModel.Codigo, addProdutoModel.Fabricacao, addProdutoModel.Preco, addProdutoModel.Validade);
            produto.Validade = DateTime.Now;
             repositorio.Add(produto);
             repositorio.SaveChanges();
            return Created($"api/produto/{produto.NomeProduto}", new { produto.Id, produto.NomeProduto, produto.Preco, produto.Validade });
        }

        
    }
}
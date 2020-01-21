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
        public async Task<IActionResult> Post([FromServices]IProdutoRepositorio repositorio, [FromBody]AddProdutoModel produtoModel)
        {
            var produto = new Produto(produtoModel.NomeProduto, produtoModel.Codigo, produtoModel.Fabricacao, produtoModel.Preco, produtoModel.Validade);
            repositorio.Add(produto);
            repositorio.SaveChanges();
            return Created($"api/produto/{produto.NomeProduto}", new { produto.Id });
        }

        


    }
}
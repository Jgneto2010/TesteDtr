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
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        [Route("addUsuario/Produto")]
        public async Task<IActionResult> AdicionandoUsuarioComListaDeProdutos([FromServices]IUsuarioRepositorio repositorio, [FromBody]AddUsuarioComProdutoModel addUsuarioComProdutoModel)
        {
            var usuario = new Usuario();
           
            usuario.NomeUsuario = addUsuarioComProdutoModel.NomeUsuario;
            usuario.EmailUsuario = addUsuarioComProdutoModel.EmailUsuario;
            usuario.PasswordUsuario = addUsuarioComProdutoModel.PasswordUsuario;
            usuario.ConfirmaPasswordUsuario = addUsuarioComProdutoModel.ConfirmaPasswordUsuario;
            usuario.ColecaoProdutos = new List<Produto>();

            foreach (var item in addUsuarioComProdutoModel.ColecaoProdutos)
            {
                var teste = new Produto(item.NomeProduto, item.CodigoProduto, item.Fabricacao, item.PrecoProduto, item.Validade);
                usuario.ColecaoProdutos.Add(teste);
            }

            repositorio.Add(usuario);
            repositorio.SaveChanges();
            return Created($"api/produto/{usuario.NomeUsuario}", new { usuario.Id, usuario.NomeUsuario, usuario.ColecaoProdutos });
        }

        [HttpPost]
        [Route("cadastrarUsuario")]
        public async Task<IActionResult> CadastrarUsuario([FromServices]IUsuarioRepositorio repositorio, [FromBody]AddUsuario addUsuario)
        {
            var usuario = new Usuario();

            usuario.NomeUsuario = addUsuario.NomeUsuario;
            usuario.EmailUsuario = addUsuario.EmailUsuario;
            usuario.PasswordUsuario = addUsuario.PasswordUsuario;
            usuario.ConfirmaPasswordUsuario = addUsuario.ConfirmaPasswordUsuario;

            repositorio.Add(usuario);
            repositorio.SaveChanges();
            return Ok(usuario);
        }



    }
}
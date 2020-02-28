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
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("ProdutosDoUsuario")]
        public IActionResult UsuarioComSeusProdutos([FromServices]IUsuarioRepositorio repositorio, [FromBody]AddUsuarioComProduto addUsuarioComProduto)
        {
            var usuario = new Usuario();
            var validacao = new UsuarioValidator().Validate(usuario);
            

            usuario.NomeUsuario = addUsuarioComProduto.NomeUsuario;
            usuario.ColecaoProdutos = new List<Produto>();

            foreach (var item in addUsuarioComProduto.ColecaoProdutos)
            {
                var teste = new Produto(item.NomeProduto, item.CodigoProduto, item.PrecoProduto, item.Fabricacao, item.Validade);
                usuario.ColecaoProdutos.Add(teste);
            }

            repositorio.Add(usuario);
            repositorio.SaveChanges();
            return Created($"api/produto/{usuario.NomeUsuario}", new { usuario.Id, usuario.NomeUsuario, usuario.ColecaoProdutos});
        }
        [HttpPost]
        [Route("cadastrarUsuario")]
        public IActionResult CadastrarUsuario([FromServices]IUsuarioRepositorio repositorio, [FromBody]AddUsuario addUsuario)
        {
            var usuario = new Usuario();
            var validacao = new UsuarioValidator().Validate(usuario);
            
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
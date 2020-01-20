﻿using System;
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
        [Route("addUsuario")]
        public async Task<IActionResult> AdicionandoUsuarioComListaDeProdutos([FromServices]IUsuarioRepositorio repositorio, [FromBody]AddUsuarioModel addUsuarioModel)
        {
            var usuario = new Usuario();
           
            usuario.NomeUsuario = addUsuarioModel.NomeUsuario;
            usuario.EmailUsuario = addUsuarioModel.EmailUsuario;
            usuario.PasswordUsuario = addUsuarioModel.PasswordUsuario;
            usuario.ConfirmaPasswordUsuario = addUsuarioModel.ConfirmaPasswordUsuario;
            usuario.ColecaoProdutos = new List<Produto>();

            foreach (var item in addUsuarioModel.ColecaoProdutos)
            {
                var teste = new Produto(item.NomeProduto, item.CodigoProduto, item.Fabricacao, item.PrecoProduto, item.Validade);
                usuario.ColecaoProdutos.Add(teste);
            }

            repositorio.Add(usuario);
            repositorio.SaveChanges();
            return Created($"api/produto/{usuario.NomeUsuario}", new { usuario.Id, usuario.NomeUsuario, usuario.EmailUsuario });
        }
        


    }
}
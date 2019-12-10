﻿using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Dominio.Validacoes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    //Essa é a Rota da Classe UsuarioController
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //Inversão de dependencia
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        
        //Este metodo traz toda a lista de usuários do banco
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return _usuarioRepositorio.GetAll().ToList();
        }

        //Este Metodo adiciona no banco Um Novo usuário e Salva esta ação
        //Usando fluentValidation
        [HttpPost]
        public ActionResult<IEnumerable<Usuario>> Post([FromBody]Usuario usuario)
        {
            var ValidacaoUsuario = new UsuarioValidator().Validate(usuario);

            if (ValidacaoUsuario.IsValid)
            {
                _usuarioRepositorio.Add(usuario);
                _usuarioRepositorio.SaveChanges();
            }
            else
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}

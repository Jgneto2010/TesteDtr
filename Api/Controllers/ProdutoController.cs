﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Contratos.Interfaces;
using Dominio.Modelo.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{   //Essa é a Rota Da classe
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        //Inversão de dependencia
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        //Esse Metodo traz a lista de produtos
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            
            return _produtoRepositorio.GetAll().ToList();
        }


        [HttpPost]
        public ActionResult<IEnumerable<Produto>> Post([FromBody]Produto produto)
        {

            _produtoRepositorio.Add(produto);
            _produtoRepositorio.SaveChanges();

            return Ok();
        }

    }
}
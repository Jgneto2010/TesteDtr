using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

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
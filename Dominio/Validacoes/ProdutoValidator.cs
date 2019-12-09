using Dominio.Modelo.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Validacoes
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(x => x.NomeProduto).NotEmpty().WithMessage("Insira Um Nome de um produto");
            RuleFor(x => x.CodigoProduto).NotEmpty().WithMessage("insira um Codigo para Cadastrar o produto");
            RuleFor(x => x.PrecoProduto).NotEmpty().WithMessage("insira um Valor");
           
        }
    }
}

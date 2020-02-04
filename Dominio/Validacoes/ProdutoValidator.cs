using Dominio.Modelo.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Dominio.Validacoes
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public void ValidNomeProduto()
        {
            RuleFor(x => x.NomeProduto).NotEmpty().WithMessage("Insira Um Nome de um produto");
        }
        public void ValidValidadeProduto()
        {
            RuleFor(x => x.Validade).NotEmpty().WithMessage("Insira Um Nome de um produto");
        }
        public void ValidCodigoProduto()
        {
            RuleFor(x => x.Codigo).NotEmpty().WithMessage("Insira Um Nome de um produto");
        }
        public void ValidPrecoProduto()
        {
            RuleFor(x => x.Preco).NotEmpty().WithMessage("Insira Um Nome de um produto");            
        }
    }
}

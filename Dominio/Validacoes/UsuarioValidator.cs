using Dominio.Modelo.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Validacoes
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.NomeUsuario).NotEmpty().WithMessage("Insira Um Nome");
            RuleFor(x => x.EmailUsuario).NotEmpty().WithMessage("insira um Email");
            RuleFor(x => x.EmailUsuario).EmailAddress().WithMessage("Formato Email Inválido");
            RuleFor(x => x.PasswordUsuario).NotEmpty().WithMessage("Insira um Password");
            RuleFor(x => x.ConfirmaPasswordUsuario).NotEmpty().WithMessage("Confirme o Password");
        }
    }
 }


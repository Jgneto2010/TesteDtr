using Dominio.Modelo.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Validacoes
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public void ValidNomeUsuario()
        {
            RuleFor(x => x.NomeUsuario).NotEmpty().WithMessage("Insira Um Nome");
            RuleFor(x => x.NomeUsuario).Length(6, 30).WithMessage("");
        }
        public void ValidEmailUsuario()
        {
            RuleFor(x => x.EmailUsuario).NotEmpty().WithMessage("Insira Um Nome");
            RuleFor(x => x.EmailUsuario).Length(6, 30).WithMessage("O nome tem que haver no minimo 6 e no maximo 30 caracteres");
        }
        public void ValidPasswordUsuario()
        {
            RuleFor(x => x.PasswordUsuario).NotEmpty().WithMessage("Insira um Password");
            RuleFor(x => x.ConfirmaPasswordUsuario).NotEmpty().WithMessage("Confirme o Password");
        }
    }
 }


﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades
{
    public class Usuario
    {
        public Usuario()
        {

        }
        public int Id { get;  set; }
        public string NomeUsuario { get;  set; }
        public string EmailUsuario { get;  set; }
        public string PasswordUsuario { get;  set; }
        public string ConfirmaPasswordUsuario { get;  set; }
       
    }
}

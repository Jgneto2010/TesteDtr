﻿using Dominio.Modelo.Entidades.EnumFormaPagamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades.FormaPagamentos
{
    public class FormaPagamento
    {
        public Guid Id { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        
    }
}
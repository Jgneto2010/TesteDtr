using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Modelo.Entidades.EnumFormaPagamento
{
    public enum TipoPagamento
    {
        NaoDefinido = 0,
        Boleto = 1,
        CartaoCredito = 2,
        CartaoDebito = 3
    }
}

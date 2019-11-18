using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class Atendente : Funcionario
    {
        public decimal ValorMensalVendido { get; set; }
        public decimal Meta { get => 2000; }
        public decimal PorcemtagemComissao { get; set; }
    }
}

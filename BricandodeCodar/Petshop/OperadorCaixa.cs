using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class OperadorCaixa : Funcionario
    {
        public decimal DiferenciaADescontarSalario { get; set; }
        public List<ControleCaixa> OperacaoCaixa { get; set; }

    }
}

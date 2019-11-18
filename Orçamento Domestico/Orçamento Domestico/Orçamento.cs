using System;
using System.Collections.Generic;
using System.Text;

namespace Orçamento_Domestico
{
    public class Orçamento : Pessoa
    {
        public List<string> Tipo { get; set; }

        public decimal DespesaFixa { get; set; }

        public decimal Despesa { get; set; }

        

    }
}

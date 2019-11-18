using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class Gerente : Funcionario
    {
        public List<Funcionario> Subordinados { get; set; }
        public string Departamento { get; set; }
    }
}

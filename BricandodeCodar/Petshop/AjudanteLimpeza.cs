using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class AjudanteLimpeza : Funcionario
    {
        public bool PossuiUniforme { get; set; }
        public string TamanhoUniforme { get; set; }
        public Turno Turno { get; set; }
    }

    public enum Turno
    {
        Manha,
        Tarde,
        Noite
    }
}

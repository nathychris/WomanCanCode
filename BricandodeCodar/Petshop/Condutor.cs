using System;
using System.Collections.Generic;
using System.Text;

namespace Petshop
{
    public class Condutor : Funcionario
    {
        public string CategoriaCNH { get; set; }
        public string PlacaDoCarro { get; set; }
        public string ModeloDoVeiculo { get; set; }
        public string Cor { get; set; }
        public TipoVeiculo TipoVeiculo { get; set; }
        public string Renavan { get; set; }
    }

    public enum TipoVeiculo
    {
        Carro,
        Moto,
        Caminhao
    }

}

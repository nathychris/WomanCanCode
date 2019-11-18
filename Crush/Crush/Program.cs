using System;
using System.Collections.Generic;

namespace Crush
{
    class Program
    {


        static void Main(string[] args)
        {
            Crush Marido = new Crush();
            Marido.Apelido = "Diego";
            Marido.Avaliacao = 8;

            Marido.Comportamento = new List<Comportamento>();

            Comportamento compEngracado = new Comportamento();
            compEngracado.Descricao = "Engraçado";
            compEngracado.Intensidade = 5;

            compEngracado.IncluirIntesidade(4);

            Marido.Comportamento.Add(compEngracado);

            Comportamento compRomantico = new Comportamento();
            compRomantico.Descricao = "Engraçado";
            compRomantico.Intensidade = 10;

            compRomantico.DiminuirIntesidade(8);

            Marido.Comportamento.Add(compEngracado);
            Marido.Comportamento.Add(compRomantico);

        }

    }  
}

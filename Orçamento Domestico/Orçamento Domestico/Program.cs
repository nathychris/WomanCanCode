using System;
using System.Collections.Generic;

namespace Orçamento_Domestico
{
    class Program
    {
        static void Main(string[] args)
        {
            Orçamento Carla = new Orçamento();

            Carla.Nome = "Carla";
            Carla.Salario = 3000;
            Carla.Parentesco = "Mãe";
            Carla.DespesaFixa = 500;
            Carla.Tipo = new List<string>();
            Carla.Tipo.Add("Agua");
            Carla.Tipo.Add("Luz");
            Carla.Tipo.Add("Mercado");

            Console.WriteLine($"Informações Carla: {Carla.Salario}, {Carla.Parentesco}");
            Console.WriteLine($"Despesas Carla: {Carla.DespesaFixa}\n\n");


            Orçamento Joao = new Orçamento();

            Joao.Nome = "João";
            Joao.Salario = 900;
            Joao.Parentesco = "Filho";
            Joao.Despesa = 250;
            Joao.Tipo = new List<string>();
            Joao.Tipo.Add("Internet");

            Console.WriteLine($"Informações João: {Joao.Salario}, {Joao.Parentesco}");
            Console.WriteLine($"Despesas João: {Joao.Despesa}\n\n");



            Orçamento Maria = new Orçamento();

            Maria.Nome = "Maria";
            Maria.Salario = 1500;
            Maria.Parentesco = "Avó";
            Maria.Despesa = 300;
            Maria.Tipo = new List<string>();
            Maria.Tipo.Add("Lazer");

            Console.WriteLine($"Informações Maria: {Maria.Salario}, {Maria.Parentesco}");
            Console.WriteLine($"Despesas Maria: {Maria.Despesa}\n\n");



            Orçamento Total = new Orçamento();

            Total.Salario = (Maria.Salario + Carla.Salario + Joao.Salario);

            Console.WriteLine($"Salário Total da casa: { Total.Salario}");



            Orçamento Gasto = new Orçamento();

            Gasto.Salario = (Maria.Despesa + Carla.DespesaFixa + Joao.Despesa);

            Console.WriteLine($"Total gasto dos integrantes da familia: { Gasto.Salario}\n\n");





        }




    }
}

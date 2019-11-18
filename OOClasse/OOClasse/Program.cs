using System;
using System.Collections.Generic;

namespace OOClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Programadora csharper = new Programadora(9, true);
            
            

            csharper.Linguagens = new List<string>();
            csharper.Linguagens.Add("C#");
            csharper.Linguagens.Add("JavaScript");

            
            csharper.Salario = 2000;
            csharper.TrabalhaNaArea = true;

            csharper.Idade = 23;
            csharper.Nome = "Natalia";
            csharper.NomeDaMae = "Claudia";

            csharper.MeuEndereco = new Endereco();
            csharper.MeuEndereco.Cidade = "Sao Paulo";
            csharper.MeuEndereco.Estado = "Sao Paulo";
            csharper.MeuEndereco.Bairro = "Jabaquara";

            Console.WriteLine($"Olá {csharper.Nome}, voce mora no bairro {csharper.MeuEndereco.Bairro}, e tem {csharper.Idade} anos");
        }
    }
}

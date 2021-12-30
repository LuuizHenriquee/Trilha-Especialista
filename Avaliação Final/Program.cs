using System;

namespace Avaliação_Final
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario1 = new Funcionario("Luiz", 8, 50);
            Funcionario funcionario2 = new Terceiro("João", 8, 20, "Itau Unibanco", 4);
            Console.WriteLine("Funcionário é terceirizado?");

            if (Console.ReadLine().ToLower() == "sim")
                funcionario2.ImprimeDados();
            else
                funcionario1.ImprimeDados();

        }
    }
}

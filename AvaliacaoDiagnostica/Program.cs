using System;
using System.Linq;

namespace AvaliacaoDiagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            var Conta = new ContaPoupanca();

            Conta.Nome = "Luiz Henrique Ferrareto Filho";
            Conta.CPF = "391.418.898-78";
            Conta.ValorCC = 1000.00M;
            Conta.ValorPoupanca = 500.00M;
            Conta.NumeroConta = 12345;

            Console.WriteLine(Conta.ToString());
            Conta.DepositoCC(500.00M);
            Conta.SaqueCC(50.00M);
            Conta.TransferenciaCCparaCP(200.00M);
            Conta.TransferirCPparaCC(500.00M);
            Console.WriteLine(Conta.ToString());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoDiagnostica
{
    public class ContaCorrente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public decimal ValorCC { get; set; }

        public ContaCorrente()
        {

        }

        public ContaCorrente(string nome, string cpf, decimal valorCC)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.ValorCC = valorCC;
        }

        public void DepositoCC(decimal valorDeposito)
        {
            this.ValorCC += valorDeposito;
            Console.WriteLine("Seu saldo agora é de R$" + this.ValorCC);
        }

        public void SaqueCC(decimal valorSaque)
        {
            this.ValorCC -= valorSaque;
            Console.WriteLine("Seu saldo agora é de R$" + this.ValorCC);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliacaoDiagnostica
{
    public class ContaPoupanca : ContaCorrente
    {
        public decimal ValorPoupanca { get; set; }
        public int NumeroConta { get; set; }

        public ContaPoupanca()
        {
            
        }

        public  void TransferenciaCCparaCP(decimal transferir)
        {
            this.ValorCC -= transferir;
            this.ValorPoupanca += transferir;

            Console.WriteLine("Transferindo " + transferir + " de Conta Corrente para Conta Poupança");
            Console.WriteLine("Saldo CC " + this.ValorCC + " Saldo Poupança " + this.ValorPoupanca);
        }

        public void TransferirCPparaCC(decimal transferir)
        {

            this.ValorCC += transferir;
            this.ValorPoupanca -= transferir;

            Console.WriteLine("Transferindo " + transferir + " de Conta Poupança para Conta Corrente");
            Console.WriteLine("Saldo CC " + this.ValorCC + " Saldo Poupança " + this.ValorPoupanca);
        }

        public override string ToString()
        {
            return "Conta : " + this.NumeroConta + "\r\n" +
                "Nome : " + this.Nome + "\r\n" +
                "CPF : " + this.CPF + "\r\n" +
                "Saldo CC : " + this.ValorCC + "\r\n" +
                "Saldo CP : " + this.ValorPoupanca ;
        }

    }
}

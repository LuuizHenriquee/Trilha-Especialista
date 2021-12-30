using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliação_Final
{
    class Terceiro  : Funcionario
    {
        public string empresaOrigem { get; set; }
        public int taxaServico { get; set; }

        public Terceiro()
        {

        }

        public Terceiro(string nome, int cargaHoraria, double valorHora,string empresaOrigem, int taxaServico)
            :base(nome,cargaHoraria,valorHora)
        {
            this.empresaOrigem = empresaOrigem;
            this.taxaServico = taxaServico;
        }

        public override double CalculaSalario()
        {
           var salario = base.CalculaSalario() ;

           return salario * taxaServico;
        }

        public override void ImprimeDados()
        {
            Console.WriteLine($"Nome: {nome} \r\nSalário: {empresaOrigem} \r\nSalário: {CalculaSalario().ToString("C", System.Globalization.CultureInfo.CurrentCulture)}");
        }
    }
}

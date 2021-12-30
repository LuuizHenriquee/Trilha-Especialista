using System;
using System.Collections.Generic;
using System.Text;

namespace Avaliação_Final
{
    class Funcionario
    {
        private string _nome;
        public string nome
        {
            get { return _nome; }
            set
            {
                if (value.Length < 2)
                    Console.WriteLine("Digite um nome válido");
                else
                    _nome = value;
            }
        }
        public int cargaHoraria { get; set; }
        public double valorHora { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, int cargaHoraria, double valorHora)
        {
            this.nome = nome;
            this.cargaHoraria = cargaHoraria;
            this.valorHora = valorHora;
            
        }

        public Funcionario(Funcionario funcionario)
        {
            this.nome = funcionario.nome;
            this.cargaHoraria = funcionario.cargaHoraria;
            this.valorHora = funcionario.valorHora;
        }

        public virtual double CalculaSalario()
        {
            return cargaHoraria * valorHora;
        }

        public virtual void ImprimeDados()
        {
            Console.WriteLine($"Nome: {nome} \r\nSalário: {CalculaSalario().ToString("C", System.Globalization.CultureInfo.CurrentCulture)}");
        }
    }
}

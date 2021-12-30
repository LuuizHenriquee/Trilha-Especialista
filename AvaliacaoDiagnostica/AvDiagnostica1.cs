using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AvaliacaoDiagnostica
{
    class AvDiagnostica1
    {
        public static void AvalicaoLogicaProgramacao()
        {
            int[] numeros = new int[10];

            Console.WriteLine("Digite 10 numeros para preencher o vetor");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Posição " + i);
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());
                numeros[i] = numeroDigitado;
            }

            while (true)
            {
                Console.WriteLine("Digite o número para pesquisar");

                int numeroPesquisado = Convert.ToInt32(Console.ReadLine());

                if (numeros.Contains(numeroPesquisado))
                    Console.WriteLine("O número " + numeroPesquisado + " foi encontrado \r\n");
                else
                    Console.WriteLine("O número " + numeroPesquisado + " não foi encontrado \r\n");

            }
        }
    }
}

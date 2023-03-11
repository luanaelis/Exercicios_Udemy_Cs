using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiferencaValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            Console.WriteLine("Informe 4 valores inteiros A, B, C e D, consecutivamente: ");
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            diferenca = (A * B) - (C * D);

            Console.WriteLine("A diferença entre os valores é de: " + diferenca);
        }
    }
}

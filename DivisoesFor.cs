using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DivisoesFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Divisões ---");
            Console.Write("Insira o número de pares de valores inteiros a serem inseridos: ");
            int N = int.Parse(Console.ReadLine());

            double resultado;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("\nInsira o par de números: ");
                string[] pares = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(pares[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(pares[1], CultureInfo.InvariantCulture);
                if(valor2 != 0)
                {
                    resultado = valor1 / valor2;
                    Console.WriteLine("Resultado da divisão = " + resultado.ToString("F1", CultureInfo.InvariantCulture));
                } else
                {
                    Console.WriteLine("Divisão impossível");
                }
            }
        }
    }
}

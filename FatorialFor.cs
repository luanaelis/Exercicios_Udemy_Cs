using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FatorialFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um valor inteiro: ");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double fatorial = 1;

            for (double i = 1; i <= N; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("O fatorial de " + N + " é igual a: " + fatorial);
        }
    }
}

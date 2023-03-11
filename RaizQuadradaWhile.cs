using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace RaizQuadradaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raizQuadrada;

            Console.WriteLine("Calcule a raiz quadrada de um número: ");
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (numero >= 0.0)
            {
                raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrada de " + numero + " é " + raizQuadrada.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");
        }

    }
}

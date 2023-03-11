using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CasosDeTestesFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Casos de Teste ------");
            Console.Write("Insira o número de casos de teste: ");
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("\nInsira os 3 valores dos casos de teste número " + i + " na mesma linha: ");
                string[] casosDeTeste = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(casosDeTeste[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(casosDeTeste[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(casosDeTeste[2], CultureInfo.InvariantCulture);

                double MP = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10;

                Console.WriteLine("A média ponderada do caso de teste " + i + " é de: " + MP.ToString("F1"));
            }

            Console.WriteLine("\n--- Fim das Médias ---");

        }
    }
}

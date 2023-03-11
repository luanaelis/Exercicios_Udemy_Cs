using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Intervalos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A;

            Console.WriteLine("Insira um valor qualquer: ");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (A < 25)
            {
                Console.WriteLine("Intervalo (0, 25)");
            } else if (A < 50)
            {
                Console.WriteLine("Intervalo (25, 50)");
            } else if (A < 75)
            {
                Console.WriteLine("Intervalo (50, 75)");
            } else if (A < 100) {

                Console.WriteLine("Intervalo (75, 100) ");
            } else
            {
                Console.WriteLine("Fora de intervalo");
            }

        }
    }
}

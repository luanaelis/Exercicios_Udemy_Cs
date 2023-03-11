using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AreaCirculo
{
    internal class Circulo
    {
        static void Main(string[] args)
        {
            double area, raio, pi;

            pi = 3.14159;

            Console.WriteLine("Informe o valor do raio de seu círculo: ");
            raio = double.Parse(Console.ReadLine());

            area = Math.Pow(raio, 2.0) * pi;

            Console.WriteLine("A área do seu círculo é de: " + area.ToString("F4", CultureInfo.InvariantCulture));
            
            
        }
    }
}

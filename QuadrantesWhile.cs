using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoordenadasWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira duas coordenadas quaisquer de seu plano cartesiano: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                Quadrantes(x, y);
                Console.WriteLine("Insira novas coordenadas:");
                string[] novaCoordenada = Console.ReadLine().Split(' ');
                x = double.Parse(novaCoordenada[0]);
                y = double.Parse(novaCoordenada[1]);
            }

            Console.WriteLine("Erro: uma ou mais coordenadas nulas");
        }
        static double Quadrantes(double x,double y)
        {
            double quad, quad1 = 1, quad2 = 2, quad3 = 3, quad4 = 4; 

            if (x > 0 && y > 0)
            {
                quad = quad1;
                Console.WriteLine("Quadrante " + quad1);
            } else if (x < 0 && y > 0)
            {
                quad = quad2;
                Console.WriteLine("Quadrante " + quad2);
            } else if (x < 0 && y < 0)
            {
                quad = quad3;
                Console.WriteLine("Quadrante " + quad3);
            } else
            {
                quad = quad4;
                Console.WriteLine("Quadrante " + quad4);
            }
            return quad; 
        }

    }
}

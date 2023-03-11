using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PlanoCartesiano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            Console.WriteLine("Insira dois valores x e y de seu plano cartesiano: ");
            string[] pontos = Console.ReadLine().Split(' ');
            X = double.Parse(pontos[0], CultureInfo.InvariantCulture);
            Y = double.Parse(pontos[1], CultureInfo.InvariantCulture);

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Seu ponto está no quadrante 1");
            } else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Seu ponto está no quadrante 2");
            } else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Seu ponto está no quadrante 3");
            } else if (X == 0 && Y == 0) {

                Console.WriteLine("Seu ponto está na origem");
            }  else 
            {
                Console.WriteLine("Seu ponto está no quadrante 4");
            }
        }
    }
}

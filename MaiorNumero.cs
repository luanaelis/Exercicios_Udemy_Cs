using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira três números inteiros: "); 
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int c = int.Parse(Console.ReadLine());


            double resultado = MaiorNumero(a, b, c);

            Console.WriteLine("Maior número = " + resultado);
        }

        static int MaiorNumero(int n1, int n2, int n3)
        {

            int maior;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n3)
            {
                maior = n2;
            }
            else
            {
                maior = n3;
            }
            return maior;
        }
    }
}

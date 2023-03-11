using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("Seu número é positivo!");

            } else if (x == 0) {

                Console.WriteLine("Seu número é nulo!");

            } else
            {
                Console.WriteLine("Seu número é negativo!");
            }
        }
    }
}

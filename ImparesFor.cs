using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImparesFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro qualquer menor ou igual a 1000: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Valores ímpares: ");

            for (int i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}

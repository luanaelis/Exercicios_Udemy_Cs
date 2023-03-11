using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervaloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra se um número está dentro ou fora do intervalo 10, 20!");
            Console.Write("Quantos números inteiros você quer quer digitar? ");
            int N = int.Parse(Console.ReadLine());

            int quantidadeIn = 0;
            int quantidadeOut = 0;

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Insira um valor: ");
                int x = int.Parse(Console.ReadLine());
                if(x >= 10 && x <= 20)
                {
                    quantidadeIn++;
                }
                else
                {
                    quantidadeOut++;
                }
            }

            Console.WriteLine("Quantidades:\nIn: " + quantidadeIn + "\nOut: " + quantidadeOut);
        }
    }
}

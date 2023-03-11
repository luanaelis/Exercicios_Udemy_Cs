using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            Console.WriteLine("Insira dois números inteiros: ");
            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]); 
            B = int.Parse(vet[1]); 

            if(A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São múltiplos entre si");

            } else
            {
                Console.WriteLine("Não são múltiplos entre si");
            }
        }
    }
}

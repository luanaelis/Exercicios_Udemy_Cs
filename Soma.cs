using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEstruturaSequencial
{
    internal class Soma
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("O resultado da sua soma é: " + soma);
            Console.ReadLine();
        }
    }
}

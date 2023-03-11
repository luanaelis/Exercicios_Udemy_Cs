using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atribuicao
{
    internal class OperadoresAtribuicao
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 3;
            Console.WriteLine(a);

            a -= 5;
            Console.WriteLine(a);

            a *= 2;
            Console.WriteLine(a);

            a /= 4;
            Console.WriteLine(a);

            a %= 4;
            Console.WriteLine(a);

            //Operadores aritméticos / atribuição

            a++;
            Console.WriteLine(a);

            a--;
            Console.WriteLine(a);

            Console.ReadLine();
        }


    }
}

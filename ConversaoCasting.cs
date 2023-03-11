using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoImplicitaCasting
{
    internal class Conversao
    {
        static void Main(string[] args)
        {
            //Casting - (float) converteu o valor double em float apesar do espaço de bytes

            double a;
            float b;

            a = 10.2;
            b = (float)a;

            Console.WriteLine(b);
            Console.ReadLine();

            //Double para int -> int apaga os valores decimais após a vírgula
        }
         
    }
}

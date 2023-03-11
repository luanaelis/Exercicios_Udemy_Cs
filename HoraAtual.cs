using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HoraAtual
{
    internal class Hora {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?"); //Apenas horas, sem minutos
            int hora = int.Parse(Console.ReadLine());
            
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");

            } else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");

            } else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}

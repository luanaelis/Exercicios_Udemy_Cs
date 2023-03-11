using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tabela de imposto de renda fictícia
            Console.WriteLine("Renda de R$0,00 a R$2000,0 => Isento\nRenda de R$2000,01 a R$3000,00 => 8%\nRenda de R$3000,01 a R$4500,00 => 18%\nRenda acima de R$4500,00 => 28%");

            double imposto;

            Console.WriteLine("Entre com seu salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000)
            {
                imposto = 0.0;
            } else if (salario <= 3000)
            {
                imposto = (salario - 2000) * 0.08;
            } else if (salario <= 4500)
            {
                imposto = (salario - 3000) * 0.18 + (1000 * 0.08);
            } else
            {
                imposto = (salario - 4500) * 0.28 + (1500 * 0.18) + (1000 * 0.08);
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento de impostos");
            } else
            {
                Console.WriteLine("A pagar: R$" + imposto.ToString("F2"));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ValorPecas
{
    internal class Pecas
    {
        static void Main(string[] args)
        {
            int codigo1, peca1, codigo2, peca2;
            float valor1, valor2, valorTotal;

            Console.WriteLine("Informe o codigo e quantidade das primeiras peças: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            peca1 = int.Parse(vet1[1]);

            Console.WriteLine("Informe o valor das primeiras peças: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o código e quantidade das segundas peças: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            peca2 = int.Parse(vet2[1]);

            Console.WriteLine("Informe o valor das segundas peças: ");
            valor2 = float.Parse(Console.ReadLine());

            valorTotal = (peca1 * valor1) + (peca2 * valor2);

            Console.WriteLine("Valor a pagar: " + valorTotal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

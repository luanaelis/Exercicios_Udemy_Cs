using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1 = 01, c2 = 02, c3 = 03, c4 = 04, c5 = 05, codigo, quantidade;
            double p1 = 7.50, p2 = 5.0, p3 = 6.0, p4 = 3.0, p5 = 4.50, precoPagar;


            Console.WriteLine("Cachorro quente -> código: " + c1 + ", valor: R$" + p1.ToString("F2"));
            Console.WriteLine("Pão de queijo -> código: " + c2 + ", valor: R$" + p2);
            Console.WriteLine("Pão de batata -> código: " + c3 + ", valor: R$" + p3);
            Console.WriteLine("Suco de caixinha -> código: " + c4 + ", valor: R$" + p4);
            Console.WriteLine("Refrigerante de lata -> código: " + c5 + ", valor: R$" + p5.ToString("F2"));

            Console.WriteLine("\nInsira o código e a quantidade do seu pedido: ");
            string[] pedido = Console.ReadLine().Split(' ');
            codigo = int.Parse(pedido[0]);
            quantidade = int.Parse(pedido[1]);

            if (codigo == 01)
            {
                precoPagar = quantidade * p1;
            } else if (codigo == 02)
            {
                precoPagar = quantidade * p2;
            } else if (codigo == 03)
            {
                precoPagar = quantidade * p3;
            } else if (codigo == 04)
            {
                precoPagar = quantidade * p4;
            } else
            {
                precoPagar = quantidade * p5;
            }

            Console.WriteLine("Valor a pagar: " + precoPagar.ToString("F2") + " reais");
        }
    }
}

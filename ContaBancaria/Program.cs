using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting.Messaging;

namespace ContaBancariaClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inical? (s/n) ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depositoInicial);
            } else
            {
                c = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: " + c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.RealizarDeposito(deposito2);
            Console.WriteLine("Dados da conta atualizados: " + c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.RealizarSaque(saque);
            Console.WriteLine("Dados da conta atualizados: " + c);
        }
    }
}

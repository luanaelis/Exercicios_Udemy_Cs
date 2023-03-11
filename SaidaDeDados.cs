using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;

            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:\n" + produto1 + ", cujo preço é $" + preco1 + ", " + produto2 + ", cujo preço é $" + preco2);
            Console.WriteLine("Registro:\n" + idade + " anos de idade, código " + codigo + " e gênero " + genero);
            Console.WriteLine("\nMedia com oito casas decimais: " + medida + "\nArredondado para três casas decimais: " + medida.ToString("F3") + "\nSeparador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}

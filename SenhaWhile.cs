using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;

            Console.WriteLine("Insira a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha incorreta!");
                Console.WriteLine("Tente novamente: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}

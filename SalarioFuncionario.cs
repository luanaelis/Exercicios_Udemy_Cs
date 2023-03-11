using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFuncionario
{
    internal class Funcionario
    {
        static void Main(string[] args)
        {
            int codigo;
            double horasTrabalhadas, valorHora, salario;

            Console.WriteLine("Informe o código do seu funcionário: ");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua carga horária diária e o valor por hora: ");
            string[] vet = Console.ReadLine().Split(' ');
            horasTrabalhadas = double.Parse(vet[0]);
            valorHora = double.Parse(vet[1]);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("Código do funcionário e seu salário:\n" + codigo + "\n" + salario.ToString("F2"));


        }
    }
}

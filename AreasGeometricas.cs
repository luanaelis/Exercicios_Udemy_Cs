using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasGeometricas
{
    internal class FormasGeometricas
    {
        static void Main(string[] args)
        {
            float A, B, C;
            double pi, triangulo, circulo, quadrado, trapezio, retangulo;
            pi = 3.14159;

            Console.WriteLine("Insira a base e a altura de seu triangulo: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            A = float.Parse(vet1[0]);
            C = float.Parse(vet1[1]);

            triangulo = A * C / 2;

            Console.WriteLine("Insira o raio do seu círculo: ");
            C = float.Parse(Console.ReadLine());

            circulo = pi * Math.Pow(C, 2);

            Console.WriteLine("Insira a base maior, base menor e altura de seu trapezio, consecutivamente: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            A = float.Parse(vet2[0]);
            B = float.Parse(vet2[1]);
            C = float.Parse(vet2[2]);

            trapezio = (A + B) * C / 2;

            Console.WriteLine("Insira o lado de seu quadrado: ");
            B = float.Parse(Console.ReadLine());

            quadrado = Math.Pow(B, 2);

            Console.WriteLine("Insira a base e a altura de seu retângulo: ");
            string[] vet3 = Console.ReadLine().Split(' ');
            A = float.Parse(vet3[0]);
            B = float.Parse(vet3[1]);

            retangulo = A * B;

            Console.WriteLine("A área de seu triângulo é de: " + triangulo.ToString("F3"));
            Console.WriteLine("A área de seu círculo é de: " + circulo.ToString("F3"));
            Console.WriteLine("A área de seu trapezio é de: " + trapezio.ToString("F3"));
            Console.WriteLine("A área de seu quadrado é de: " + quadrado.ToString("F3"));
            Console.WriteLine("A área de seu retângulo é de: " + retangulo.ToString("F3"));
            


        }
    }
}

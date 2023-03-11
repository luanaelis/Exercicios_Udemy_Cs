using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting.Messaging;

namespace Horas_de_Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, horasDeJogo;

            Console.WriteLine("Insira a hora inicial e a hora final de seu jogo: "); //Apenas número de horas, sem minutos
            string[] vet = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);  
            
            if (horaInicial < horaFinal)
            {
                horasDeJogo = horaFinal - horaInicial;
            } else
            {
                horasDeJogo = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou " + horasDeJogo + " horas");
        }
    }
}

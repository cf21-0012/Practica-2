using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___Palindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime la torre de hanoi");
            Console.WriteLine("Ingrese el número de discos: ");
            int nDiscos = int.Parse(Console.ReadLine());

            Console.WriteLine("Los pasos para resolver la Torre de Hanoi son:");
            Hanoi(nDiscos, 'A', 'C', 'B');

            Console.ReadLine();
        }

        static void Hanoi(int nD, char inicio, char final, char extra)
        {
            if (nD == 1)
            {
                Console.WriteLine("Moviendo el disco 1 de la torre {0} hasta la torre {1}", inicio, final);
            }
            else
            {
                Hanoi(nD - 1, inicio, extra, final);
                Console.WriteLine("Moviendo el disco {0} de la torre {1} hasta la torre {2}", nD, inicio, final);
                Hanoi(nD - 1, extra, final, inicio);
            }
        }
    }
}

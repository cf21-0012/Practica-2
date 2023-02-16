using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_6___Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine("Programa que simula la loteria nacional");
            Console.WriteLine("Presione para iniciar la tombola ");
            Console.ReadKey();
            
            
            Console.Write("La tombola esta girando...\n");
            Thread.Sleep(5000);

            int n1 = rand.Next(0, 99);
            Console.Write("\nHa salido el numero " + n1 + "!!!\n");


            Console.Write("La tombola esta girando...\n");
            Thread.Sleep(5000);

            int n2 = rand.Next(0, 99);
            Console.Write("\nHa salido el numero " + n2 + "!!!\n");

            Console.Write("La tombola esta girando...\n");
            Thread.Sleep(5000);

            int n3 = rand.Next(0, 99);
            Console.Write("\nHa salido el numero " + n3 + "!!!\n");


            Thread.Sleep(1500);
            Console.WriteLine("Los números salidos de la tombola son: {0}, {1}, {2}", n1, n2, n3);
            Console.WriteLine("\n Buena suerte en su próxima apuesta!");

            Console.ReadLine();
        }
    }
}

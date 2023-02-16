using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___Operaciones_con_cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula suma y resta de cubos.
            Console.Write("Ingrese el primero: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo: ");
            int n2 = int.Parse(Console.ReadLine());

            int restaC = (int)(Math.Pow(n1, 3) - Math.Pow(n2, 3));
            int sumaC = (int)(Math.Pow(n1, 3) + Math.Pow(n2, 3));
           

            Console.WriteLine("La suma de cubos de " +n1 +" y " +n2 +" es " + sumaC + " y la resta de cubos es " +restaC);
            Console.Read();
        }
    }
}

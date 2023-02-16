using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_0___Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que convierte fracciones mixtas a comunes");
            Console.WriteLine("Introduzca el entero: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el numerador: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca el denominador: ");
            int d = int.Parse(Console.ReadLine());

            e = e * d;
            n = n + e;

            Console.WriteLine("La fraccion resultante es: ");
            Console.WriteLine(n);
            Console.WriteLine("--");
            Console.WriteLine(+d);


        }
    }
}

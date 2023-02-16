using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7___Biciesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que determina si el año es bisiesto");
            Console.WriteLine("Digite el año: ");
            int año = int.Parse(Console.ReadLine());

            if (Bisiesto(año))
            {
                Console.WriteLine(año + " es un año bisiesto.");
            }
            else
            {
                Console.WriteLine(año +" no es un año bisiesto.");
            }

            Console.ReadLine();
        }

        static bool Bisiesto(int a)
        {
            if (a % 4 != 0)
            {
                return false;
            }
            else if (a % 100 != 0)
            {
                return true;
            }
            else if (a % 400 != 0)
            {
                return false;
            }
            else if (a % 4000 != 0) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Primos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Programa que imprime los numeros primos.
            Console.Write("Ingrese el inicial: ");
            int ninicial = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el final: ");
            int  nfinal = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números primos entre "+ninicial +" y " +nfinal);
            NumPrimo(nfinal);

            Console.Read();
        }

        static void NumPrimo(int n)
        {
            bool[] primos = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                primos[i] = true;
            }

            for (int a = 2; a * a <= n; a++)
            {
                if (primos[a] == true)
                {
                    for (int i = a * a; i <= n; i += a)
                    {
                        primos[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (primos[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

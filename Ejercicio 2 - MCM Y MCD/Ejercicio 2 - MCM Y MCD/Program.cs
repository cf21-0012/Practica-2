using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___MCM_Y_MCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el MCM Y MCD");
            Console.Write("Ingrese el primero: ");
            int ninicial = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo: ");
            int nfinal = int.Parse(Console.ReadLine());

            int div = 2;
            int mcd = 1;
            int mcm = 1;

            while (ninicial > 1 || nfinal > 1)
            {
                if (ninicial % div == 0 && nfinal % div == 0)
                {
                    mcd *= div;
                    mcm *= div;
                    ninicial /= div;
                    nfinal /= div;
                }
                else if (ninicial % div == 0)
                {
                    mcm *= div;
                    ninicial /= div;
                }
                else if (nfinal % div == 0)
                {
                    mcm *= div;
                    nfinal /= div;
                }
                else
                {
                    div++;
                }
            }

            Console.WriteLine("El MCM de " +ninicial +" y " +nfinal +" es " +mcm);
            Console.WriteLine("El MCD de " +ninicial + " y " +nfinal + " es " + mcd);

            Console.Read();
        }
    }
}

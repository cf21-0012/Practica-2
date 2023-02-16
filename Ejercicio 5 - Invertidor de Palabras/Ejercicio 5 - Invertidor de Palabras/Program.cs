using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___Invertidor_de_Palabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imrpime las palabras invertidas");
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();

            char[] letras = palabra.ToCharArray();
            int length = letras.Length;
            char[] letrasR = new char[length];

            for (int i = 0; i < length; i++)
            {
                letrasR[i] = letras[length - i - 1];
            }

            string palabraR = new string(letrasR);

            Console.WriteLine("La palabra invertida es: " +palabraR);

            Console.ReadLine();
        }
    }
}

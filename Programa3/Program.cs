using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando variables
            int numero;
            bool correcto = false;
            string dato;

            //Recogiendo variables
            Console.WriteLine("==========================");
            Console.WriteLine("    NUMERO PAR O IMPAR    ");
            Console.WriteLine("==========================");
            Console.Write("Ingrese un número entero: ");
            dato = Console.ReadLine();

            if (int.TryParse(dato, out numero))
            {
                correcto = true;
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Es PAR");
                }
                else
                {
                    Console.WriteLine("Es IMPAR");
                }
            }
            else
            {
                Console.WriteLine("Número no válido. Se cerrará el programa.");
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarando variables
            double temperatura, conversion;
            string medida, dato;

            //Recogidendo variables
            Console.WriteLine("=========================");
            Console.WriteLine("CONVERSOR DE TEMPERATURAS");
            Console.WriteLine("=========================");
            Console.Write("Ingrese la temperatura en °C: ");
            dato = Console.ReadLine();

            if (double.TryParse(dato, out temperatura))
            {
                Console.WriteLine("Convertir a:");
                Console.WriteLine("(F)ahrenheit");
                Console.WriteLine("(K)elvin");
                medida = Console.ReadLine().ToUpper();

                if (medida == "F")
                {
                    conversion = (temperatura * 1.80) + 32;
                    Console.Write("Respuesta: {0}°C equivale a {1}°F", temperatura, conversion);
                }
                else if (medida == "K")
                {
                    conversion = temperatura + 273.15;
                    Console.Write("Respuesta: {0}°C equivale a {1} Kelvin", temperatura, conversion);
                }
                else
                {
                    Console.WriteLine("Error: Se esperaba 'F' o 'K'. Se finalizará el programa");
                }
            }
            else
            {
                Console.WriteLine("Error: Se esperaba un número. Se finalizará el programa");
            }

            Console.ReadKey();

        }
    }
}

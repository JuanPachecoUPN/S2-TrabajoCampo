using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2TrabajoCampo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Programa 1: Conversor de temperaturas
            double temperatura, conversion;
            string medida, dato;

            //Recogidendo variables
            Console.WriteLine("=========================");
            Console.WriteLine("CONVERSOR DE TEMPERATURAS");
            Console.WriteLine("=========================");
            Console.Write("Ingrese la temperatura en °C: ");
            dato = Console.ReadLine();

            if (double.TryParse(dato, out temperatura)) {
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
                else {
                    Console.WriteLine("Error: Se esperaba 'F' o 'K'. Se finalizará el programa");
                }
            } else {
                Console.WriteLine("Error: Se esperaba un número. Se finalizará el programa");
            }

            Console.ReadKey();

            //Programa 2: Promedio de notas

            //Programa 3: Nunmero par o impar

            //Programa 3: Nunmero par o impar
            int numero;
            bool correcto = false;

            //Recogidendo variables
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
                Console.ReadKey();
                Console.Clear();
            }  

            Console.ReadKey();

            //Programa 4: Calculadora básica


        }
    }
}

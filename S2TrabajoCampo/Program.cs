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

            //Programa 3: Numero par o impar
            int numero;
            bool correcto = false;

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
                Console.ReadKey();
                Console.Clear();
            }  

            Console.ReadKey();

            //Programa 4: Calculadora básica

            int opcion;
            double n1, n2;

            do
            {
                Console.Clear();
                Console.WriteLine("*************ALCULADORA*************");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                Console.WriteLine("************************************");
                Console.Write("Seleccione una operación (1 al 4): ");

                opcion = int.Parse(Console.ReadLine());

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.WriteLine("************************************");
                    Console.Write("Ingrese el primer numero: ");
                    n1 = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese el segundo numero: ");
                    n2 = double.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {n1} + {n2} = {(n1 + n2)}");
                            break;
                        case 2:
                            Console.WriteLine($"Resultado: {n1} - {n2} = {(n1 - n2)}");
                            break;
                        case 3:
                            Console.WriteLine($"Resultado: {n1} * {n2} = {n1 * n2}");
                            break;
                        case 4:
                            if (n2 != 0)
                            {
                                Console.WriteLine($"Resultado: {n1} / {n2} = {n1 / n2}");
                            }
                            else
                            {
                                Console.WriteLine("No se puede dividir entre 0");
                            }
                            break;
                    }


                }
                else
                    if (opcion != 5)
                {
                    Console.WriteLine("Intente de nuevo.");
                }
                Console.WriteLine("\nPresione una tecla para continuar ....");
                Console.ReadKey();

            } while (opcion != 5);

            Console.ReadKey();
        }
    }
}

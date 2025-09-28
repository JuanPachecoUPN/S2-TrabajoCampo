using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Campo_S2_P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

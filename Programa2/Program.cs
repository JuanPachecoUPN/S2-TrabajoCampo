using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2.V
{
    internal class Program
    {
        static void Main()
        {
            double nota1, nota2, nota3, promedio;

            Console.Write("Ingrese la primera nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tercera nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            // Calcular el promedio
            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"\nEl promedio es: {promedio:F2}");

            if (promedio >= 13)
            {
                Console.WriteLine("El estudiante está APROBADO ✅");
            }
            else
            {
                Console.WriteLine("El estudiante está DESAPROBADO ❌");
            }
        }
    }
}


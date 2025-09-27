
namespace S2_TrabajoCampo___05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el monto de la compra: ");
            double monto = double.Parse(Console.ReadLine());

            double descuento = 0;
            if (monto > 200)
            {
                descuento = monto * 0.15;
            }

            double total = monto - descuento;

            Console.WriteLine("RESULTADOS:");
            Console.WriteLine("Subtotal: S/. " + monto);
            Console.WriteLine("Descuento aplicado: S/. " + descuento);
            Console.WriteLine("Total a pagar: S/. " + total);
        }
    }
}

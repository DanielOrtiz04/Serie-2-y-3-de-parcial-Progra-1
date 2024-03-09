using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calcular 3 productos
            Console.Write("Bienvenido");
            Console.WriteLine("Ingrese su nombre:");
            string nombreUsuario = Console.ReadLine();

            double[] ingresos = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingrese primer producto {i + 1}: ");
                ingresos[i] = Convert.ToDouble(Console.ReadLine());
            }

            CalcularSuma(ingresos, nombreUsuario);
        }

        static void CalcularSuma(double[] ingresos, string nombreUsuario)
        {
            double sumaIngresos = 0;
            foreach (var ingreso in ingresos)
            {
                sumaIngresos += ingreso;
            }

            double Ingresos = sumaIngresos / ingresos.Length;

            Console.WriteLine($" El Total es:  {sumaIngresos} ");
            Console.ReadLine();
        }
    }
}
       
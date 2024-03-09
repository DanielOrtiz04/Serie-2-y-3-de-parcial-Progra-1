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
            string nombre;
            Console.Write("Bienvenido ");
            Console.Write("Dime un nombre y apellido: ");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre + "@gmail.com");
            Console.ReadLine();
        }
    }
}
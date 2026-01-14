using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi Calculadora");
            Console.WriteLine(" 1. Suma");
            Console.WriteLine(" 2. Resta");
            Console.WriteLine(" 3. Division");
            Console.WriteLine(" 4. Multiplicación");
            Console.WriteLine(" Seleccione una opción: ");
            int respuesta = int.Parse(Console.ReadLine());

        }
    }
}

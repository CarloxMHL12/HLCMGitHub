using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0;

            do
            {
                Console.WriteLine("Calculadora Basica");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Salir");
                Console.WriteLine("¿Que opción desea?");
                respuesta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero");
                double Numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero");
                double Numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                switch (respuesta)
                {
                    case 1:
                        resultado = Numero1 + Numero2;
                        Console.WriteLine("El resultado es: " + resultado); 
                        break;

                    case 2:
                        resultado = Numero1 - Numero2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break; 

                    case 3:
                        resultado = Numero1 * Numero2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break; 

                    case 4:
                        resultado = Numero1 / Numero2;
                        Console.WriteLine("El resultado es: " + resultado);
                        break; 

                    case 5:
                        Console.WriteLine("Gracias");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                Console.ReadKey();
            } while (respuesta != 5);


        }
    }
}

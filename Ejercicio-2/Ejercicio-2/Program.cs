using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de texto
            Console.WriteLine("Ingrese un texto");

            //Lectura de texto
            string texto = Console.ReadLine();

            //Impresión de texto
            Console.WriteLine("El texto ingresado fue: " + texto);

            Console.ReadKey();
        }
    }
}

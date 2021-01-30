using System;

namespace GUIA_3_EJERCICIO_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *PROGRAMACION ESTRUCTURADA G07L
             *REBECA SARAÍ ALVARENGA HERNÁNDEZ
             *
             *EJERCICIO #4 GUIA 3
             */

            double x1, y1, x2, y2, P;
            Console.WriteLine("Hola, te pedire 4 diferentes tipos de datos en el siguiente orden:\nx1, y1, x2, y2");
            Console.WriteLine("\nBien, ahora ingrese el valor para x1...");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bien, ahora ingrese el valor para y1...");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bien, ahora ingrese el valor para x2...");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bien, ahora ingrese el valor para y2...");
            y2 = Convert.ToDouble(Console.ReadLine());
            P = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
            Console.WriteLine("\nEl perimetro tiene un total de " + P);
            Console.WriteLine("\nPresione cualquier tecla para finalizar el programa...");
            Console.ReadKey();
        }
    }
}

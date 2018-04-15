using System;

namespace SobrepasandoLimites
{
    class Program
    {
        static void Main(string[] args)
        {
            //checked
            //{
            //    int numero = int.MaxValue - 1;
            //    Console.WriteLine(numero);
            //    numero++;
            //    Console.WriteLine(numero);
            //    numero++;
            //    Console.WriteLine(numero);
            //    numero++;
            //    Console.WriteLine(numero);
            //}

            //try
            //{
            //    checked
            //    {
            //        int numero = int.MaxValue - 1;
            //        Console.WriteLine(numero);
            //        numero++;
            //        Console.WriteLine(numero);
            //        numero++;
            //        Console.WriteLine(numero);
            //        numero++;
            //        Console.WriteLine(numero);
            //    }

            //}
            //catch (OverflowException  ex)
            //{
            //    Console.WriteLine("El código produjo la siguiente excepción: " + ex.Message);
            //}

            //unchecked evita que el compilador advierta de errores en el código contenido
            //unchecked
            //{
            //    int numero = int.MinValue - 1;
            //    Console.WriteLine(++numero);
            //}

            int numero;

            Console.ReadKey();
        }
    }
}

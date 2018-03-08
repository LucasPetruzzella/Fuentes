using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

            Console.WriteLine($"El primer parámetro definirá el alto: {args[0]}");
            Console.WriteLine($"El segundo parámetro definirá el ancho: {args[1]}");

            Console.WindowHeight = int.Parse (args[0]);
            Console.WindowWidth = int.Parse (args[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Vaya! Algunos de los parámetros de inicio es incorrecto.");
            }
            Console.ReadKey();
        }
    }
}

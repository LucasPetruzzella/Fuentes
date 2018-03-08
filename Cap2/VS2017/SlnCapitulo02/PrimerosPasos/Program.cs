using System;

namespace PrimerosPasos
{
    class Program
    {
        // El método Main se define en PASCAL
        static void Main(string[] args) 
        {
            int numeroDecimal = 539_780; // es equivalente a 539.780 en base 10 (decimal)
            int numeroBinario = 0b1000_0011_1100_1000_0100; // es equivalente a 539.780 en base 2 (binario)
            int numeroHexadecimal = 0x83C84; // es equivalente a 539.780 en base 16 (hexadecimal)

            if (numeroDecimal == numeroBinario && numeroBinario == numeroHexadecimal)
            {
                Console.WriteLine("¡Los tres valores son iguales!");
            }
            else
            {
                Console.WriteLine("¡Los valores no coinciden!");
            }

            Console.ReadKey();
        }
    }
}
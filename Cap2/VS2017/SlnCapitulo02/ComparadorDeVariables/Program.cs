using System;

namespace ComparadorDeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[2];
            nombres[0] = "Hernaldo González";
            nombres[1] = "Lucas Petruzzella";

            //Utilizando for
            for (int i = 0;i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre {(i + 1).ToString()} = {nombres[i]}");
            }

            //Utilizando foreach
            var index = 1; //Variable para contar la posicion del nombre
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Nombre {index.ToString()} = {nombre}");
                index++;
            }

            Console.ReadKey();
        }

        
    }
}

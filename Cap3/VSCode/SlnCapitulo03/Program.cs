using System;

namespace SlnCapitulo03
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numero = 6;

            //Sentencia if
            //if (numero >= 5) {
            //    Console.WriteLine("El número es mayor o igual a 5");
            //}
            //else
            //{
            //    Console.WriteLine("El número es menor a 5");
            //}

            //Sentencia if de solo una linea
            //if (numero >= 5)
            //    Console.WriteLine("El número es mayor o igual a 5");
            //else
            //    Console.WriteLine("El número es menor a 5");

            //object obj = 5;

            ////Validando si una variable pertenece a una Clase
            //if (obj is int x)
            //    Console.WriteLine("obj es entero y su representación es: " + x.ToString());
            //else
            //    Console.WriteLine("obj no puede representarse como un entero");

            //Sentencia Switch
            //Console.WriteLine("Teclea un número del 1 al 5 y te lo diré en letras: ");
            //string numeroIngresado = Console.ReadKey().KeyChar.ToString();

            //Console.WriteLine("**Validando Número Ingresado**");
            //switch (numeroIngresado)
            //{
            //    case "1":
            //        Console.WriteLine("Ingresó el número UNO");
            //        break;
            //    case "2":
            //        Console.WriteLine("Ingresó el número DOS");
            //        break;
            //    case "3":
            //        Console.WriteLine("Ingresó el número TRES");
            //        break;
            //    case "4":
            //        Console.WriteLine("Ingresó el número CUATRO");
            //        break;
            //    case "5":
            //        Console.WriteLine("Ingresó el número CINCO");
            //        break;
            //    default:
            //        Console.WriteLine("Lo siento, debía ser un número del 1 al 5");
            //        break;
            //}

            //Sentencia Switch utilizando Clases
            //object texto = "2018-01-01";

            //switch (texto)
            //{
            //     case String str when DateTime.Parse(texto.ToString()).Year is 2018:
            //        Console.WriteLine("La variable texto es de tipo String, Convertido en fecha pertenece al 2018");
            //        break;
            //    case DateTime dt:
            //        Console.WriteLine("La variable texto es de tipo DateTime.");
            //        break;
            //    default:
            //        Console.WriteLine("La variable texto es de algún otro tipo.");
            //        break;
            //}


            //Sentencia WHILE
            //int contador = 0;

            //while (contador < 10)
            //{
            //    Console.WriteLine($"El contador va en: {contador}");
            //    contador++;
            //}


            //Sentencia Do
            //string palabra = string.Empty;
            //do
            //{
            //    Console.Write("Ingrese una palabra de 5 caracteres: ");
            //    palabra = Console.ReadLine();
            //} while (palabra.Length != 5);

            //Console.WriteLine($"¡Bien Hecho! {palabra} tiene 5 caracteres.");

            //Sentencia for
            //for (int contador = 0;contador < 10; contador++)
            //{
            //    Console.WriteLine($"Contador utilizando for. Valor actual: {contador}");
            //}

            //Sentencia foreach
            //string[] integrantes = { "Lucas", "Matias", "Hernaldo", "Alexis" };
            //int posicion = 1;

            //Console.WriteLine("Los Integrantes son los siguientes: ");
            //foreach (string persona in integrantes)
            //{
            //    Console.WriteLine($"{posicion}.{persona}");
            //    posicion++;
            //}

            //IEnumerator e = integrantes.GetEnumerator();
            //while (e.MoveNext())
            //{
            //    string persona = (string)e.Current; // Current is read-only!
            //    Console.WriteLine("Los Integrantes son los siguientes: ");
            //}

            double x = 11.7;
            int y = x;
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}

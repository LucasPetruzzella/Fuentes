using System;
using System.Collections;

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

            //Conversión explícita
            //long x = 11;
            //int y = (int)x;
            //Console.WriteLine($"La variable {nameof(x)} es de tipo {x.GetType().ToString()} y su valor es {x}");
            //Console.WriteLine($"La variable {nameof(y)} es de tipo {y.GetType().ToString()} y su valor es {y}");
            //Console.WriteLine("Ahora establecemos el valor de x al máximo posible.");
            //x = long.MaxValue;
            //y = (int)x;
            //Console.WriteLine($"La variable {nameof(x)} es de tipo {x.GetType().ToString()} y su valor es {x}");
            //Console.WriteLine($"La variable {nameof(y)} es de tipo {y.GetType().ToString()} y su valor es {y}");

            //Usando Convert
            //double y = 11.7;
            //int x = Convert.ToInt32(y);
            //Console.WriteLine($"x tiene un valor de {x} mientras que y vale {y}");

            //Redondeando
            //double a = 9.49;
            //double b = 9.5;
            //double c = 10.49;
            //double d = 10.5;
            //Console.WriteLine($"a decimal es {a} y entero es {Convert.ToInt32(a)}");
            //Console.WriteLine($"b decimal es {b} y entero es {Convert.ToInt32(b)}");
            //Console.WriteLine($"c decimal es {c} y entero es {Convert.ToInt32(c)}");
            //Console.WriteLine($"d decimal es {d} y entero es {Convert.ToInt32(d)}");

            //Convirtiendo a String
            //int numero = 10;
            //Console.WriteLine("Desde int: " + numero.ToString());
            //bool booleano = true;
            //Console.WriteLine("Desde bool: " + booleano.ToString());
            //DateTime fecha = DateTime.Now;
            //Console.WriteLine("Desde DateTime: " + fecha.ToString());
            //object obj = new object();
            //Console.WriteLine("Desde Object: " + obj.ToString());

            //Convirtiendo a bytes
            //byte[] arregloDeBytes = new byte[128];
            //(new Random()).NextBytes(arregloDeBytes); // Se generan bytes aleatorios
            //Console.WriteLine("Arreglo de Bytes:");
            //for (int index = 0; index < arregloDeBytes.Length; index++)
            //{
            //    Console.Write($"{arregloDeBytes[index]:X} "); // Se recorre el arreglo y muestran los bytes en consola.
            //}
            //Console.WriteLine();

            //// Convirtiendo a Base64
            //string texto = Convert.ToBase64String(arregloDeBytes);
            //Console.WriteLine($"El Arreglo en Base64: {texto}");

            //De string a otros objetos
            //string edadS = "25";
            //int edadI = int.Parse(edadS);
            //DateTime nacimiento = DateTime.Parse("1992-06-09");
            //Console.WriteLine($"Tengo {edadI} años.");
            //Console.WriteLine($"Mi fecha de nacimiento es el {nacimiento}.");
            //Console.WriteLine($"También puede escribirse así: {nacimiento:D}.");

            //De string a int con tryParse
            //int cantidad;
            //Console.Write("Ingrese su edad en números: ");
            //string numeroIngresado = Console.ReadLine();
            //if (int.TryParse(numeroIngresado,out cantidad)) { 
            //    Console.WriteLine($"¡Bién! Entonces tienes {cantidad} años");
            //}else       
            //{
            //    Console.WriteLine("¡El número ingresado es inválido!");
            //}


            //De string a int con try-catch
            //Console.Write("Ingrese su edad en números: ");
            //string numeroIngresado = Console.ReadLine();
            //try
            //{
            //    int cantidad = int.Parse(numeroIngresado);
            //    Console.WriteLine($"¡Bién! Entonces tienes {cantidad} años");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("¡El número ingresado es inválido!");
            //}

            //Excepciones específicas
            Console.Write("Ingrese su edad en números: ");
            string numeroIngresado = Console.ReadLine();
            try
            {
                int cantidad = int.Parse(numeroIngresado);
                Console.WriteLine($"¡Bién! Entonces tienes {cantidad} años");
            }
            catch (FormatException)
            {
                Console.WriteLine("El número ingresado no tiene el formato correcto.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es válido, pero es demasiado grande o pequeño para ser una edad.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se produjo la siguiente excepción {ex.Message}");
            }



            Console.ReadKey();
        }
    }
}

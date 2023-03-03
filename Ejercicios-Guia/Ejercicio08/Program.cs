/*Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.*/

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int x;
            int y;

            Console.WriteLine("Ingrese un numero que represente la altura del triangulo deseada.");

            if (int.TryParse(Console.ReadLine(), out int triangleSize))
            {
                for (x = 1; x <= triangleSize; x++)
                {
                    for (y = triangleSize - x; y > 0; y--)
                    {
                        Console.Write(" ");

                    }
                    for (y = 1; y < x; y++)
                    {
                        Console.Write("**");
                    }
                    Console.WriteLine("*");
                }
            }
            else
            {
                Console.WriteLine("Ingrese bien los datos.");
            }           
        }
    }
}
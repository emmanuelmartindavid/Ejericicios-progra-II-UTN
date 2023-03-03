/*Consigna
Escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo 
ingresando un número entero positivo. 
Para el ejemplo anterior, la altura ingresada fue de 5..*/

namespace Ejercicio07
{
    internal class Program
    {
        static void Main()
        {
            string triangle = "*";
                     
            Console.WriteLine("Ingrese un numero que represente la altura del triangulo deseada.");
         
            if(int.TryParse(Console.ReadLine(), out int triangleSize))
            {
                for (int i = 0; i < triangleSize; i++)
                {
                    Console.WriteLine(triangle);
                    triangle += "**";
                }
            }
            else
            {
                Console.WriteLine("Ingrese bien los datos.");
            }
            
        }


       
    }
}
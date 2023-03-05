/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/
namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            bool validYear = false;

            while (!validYear)
            {
                Console.WriteLine("Ingrese un año:");
                validYear = int.TryParse(Console.ReadLine(), out year);

                if (!validYear)
                {
                    Console.WriteLine("El valor ingresado no es un número válido.");
                }
                else if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    Console.WriteLine("Es un año bisiesto.");
                }
                else
                {
                    Console.WriteLine("No es un año bisiesto.");
                }
            }

        }
    }
}
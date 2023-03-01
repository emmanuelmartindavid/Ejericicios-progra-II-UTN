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
            bool f = true;

            do
            {
                string numberString = Console.ReadLine();
                int.TryParse(numberString, out year);

                if (year % 4 == 0 && year % 400 == 0)
                {
                    Console.WriteLine("Es anio bisiesto");
                }
                else
                {
                    Console.WriteLine("No es anio bisiesto");
                }

            } while (f);
       
        }
    }
}
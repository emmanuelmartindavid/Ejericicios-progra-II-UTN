/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos 
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Utilizar sentencias de iteración y selectivas.*/
namespace Ejercicio_04
{
    internal class Program
    {
        static void Main()
        {
           
            int number = 1;
            int NumbersFound = 0;

            while (NumbersFound < 4)
            {
                int perfectNumbers = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        perfectNumbers += i;                    
                    }
                }
                if (perfectNumbers == number)
                {
                    Console.WriteLine(perfectNumbers);
                    NumbersFound++;
                }
                number++;
            }
        }
    }
}
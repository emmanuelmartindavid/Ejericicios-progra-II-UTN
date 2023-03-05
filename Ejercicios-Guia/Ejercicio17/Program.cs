/*El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, 

    por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.*/
namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalulateFactorial(9));
        }

        public static int CalulateFactorial(int number)
        {
            int i = number;
            if (number == 0)
            {
                return 1;
            }
            while (i > 1)
            {
                i--;
                number *= i;
            }
            return number;
        }

        /*public static int CalculateFactorialRecursive(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * CalculateFactorialRecursive(number - 1);
        }*/

        /*public static int CalculateFactorialFor(int number)
        {
            int factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }*/
    }
}
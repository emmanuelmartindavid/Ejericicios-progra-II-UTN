//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

namespace Ejercicio_01
{

    internal class Program
    {
        static void Main()
        {
            bool flagMaximus = false;
            bool flagMinimus = false;
            int minimum = 0;
            int maximus = 0;
            int total = 0;
            decimal average = 0;
            int i;

            Console.WriteLine("Ingrese 5 numeros, por favor.");

            for (i = 0; i < 5; i++)
            {

               if(int.TryParse(Console.ReadLine(), out int number))
                {
                    total += number;
                    average = CalculateAverage(total);

                    if (flagMaximus == false || number > maximus)
                    {
                        flagMaximus = true;
                        maximus = number;

                    }
                    if (flagMinimus == false || number < minimum)
                    {
                        flagMinimus = true;
                        minimum = number;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese bien los datos.");
                    break;

                }
                if (i == 4)
                {
                    Console.WriteLine("Numero minimo\n" + minimum);
                    Console.WriteLine("Numero maximo\n" + maximus);
                    Console.WriteLine("Promedio\n" + average);
                }
            }         
        }
        static decimal CalculateAverage(int numbers)
        {
            decimal average;

            average = (decimal)numbers / 5;

            return average;
        }
    }
}
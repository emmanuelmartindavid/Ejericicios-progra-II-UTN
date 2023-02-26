//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

namespace Ejercicio_01
{
 
        internal class Program
        {
            static void Main()
            {
                string numberString;
                bool flagMaximus = false;
                bool flagMinimus = false;
                int minimum = 0;
                int maximus = 0;
                int total = 0;
                float average = 0;

                Console.WriteLine("Ingrese 5 numeros, por favor.");

                for (int i = 0; i < 5; i++)
                {
                    numberString = Console.ReadLine();

                    int.TryParse(numberString, out int number);

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
                Console.WriteLine("Numero minimo\n" + minimum);
                Console.WriteLine("Numero maximo\n" + maximus);
                Console.WriteLine("Average\n" + average);
            }
            static float CalculateAverage(int numbers)
            {
                float average;

                average = numbers / 5;

                return average;
            }

        }


    
}
/*
 Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

IMPORTANTE
Utilizar variables escalares, NO utilizar vectores/arrays.
 */

using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio09
{
    class Program
    {
        //ATRIBUTOS ESTATICOS DE CLASS PROGRAM
        private static int maximus;
        private static int minimus;
        static void Main(string[] args)
        {
            short counter = 0;
            int total = 0;
            decimal average = 0;
            int minimusValue = -100;
            int maximusValue = 100;
            minimus = int.MaxValue;
            maximus = int.MinValue;
      
            Console.WriteLine("Ingrese 10 numeros entre el -100 y el 100, por favor.");
            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {                   
                    if (Validator.ValidateRange(number, minimusValue, maximusValue))
                    {
                        counter++;
                        total += number;
                        EvaluateMaximus(number);
                        EvaluateMinimus(number);
                        average = CalculateAverage(total, counter);

                    }
                    else
                    {
                        Console.WriteLine(number + "\nNo esta en el rango");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese bien los datos, por favor.");
                    break;
                }
            }            
            Console.WriteLine(ShowData(minimus, maximus, average));
        }

        static decimal CalculateAverage(int numbers, int divider)
        {
            decimal average = 0;
            if(divider > 0)
            {
                average = (decimal)numbers / divider;
            }
            return average;
        }

        static void EvaluateMaximus(int value)
        {
            if (value > maximus)
            {
                maximus = value;
            }
        }

        static void EvaluateMinimus(int value)
        {
            if (value < minimus)
            {
                minimus = value;
            }
        }

        static string ShowData(int minimus, int maximus, decimal average)
        {
            StringBuilder sb = new ();            

            sb.AppendLine($"Numero minimo: {minimus}");
            sb.AppendLine($"Numero maximo: {maximus}");
            sb.AppendLine($"Promedio: {average:#.00}");

            return sb.ToString();
        }
    }
}
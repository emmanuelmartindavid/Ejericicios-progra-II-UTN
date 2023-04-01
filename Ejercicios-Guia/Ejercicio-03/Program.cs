/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

Utilizar sentencias de iteración, selectivas y el operador módulo (%).*/
using System;
using System.Text;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numberString;
            int number;
            bool isPrime;
            bool cylce = true;

            do
            {
                Console.WriteLine("Ingrese un numero primo. Ingrese salir para terminar el programa.");
                numberString = Console.ReadLine();

                if (numberString.ToLower() == "salir")
                {
                    return;
                }

                int.TryParse(numberString, out number);


                Console.WriteLine("Numeros primos: ");
                do
                {

                    isPrime = ValidatePrimeNumber(number);


                    if (isPrime && number > 1)
                    {

                        Console.WriteLine(number);
                    }

                    number--;

                } while (number != 0 && number >= 0);

            } while (cylce);



            static bool ValidatePrimeNumber(int number)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

         /* static string ListPrimeNumbers(int to)
            {

                StringBuilder sb = new();

                for (int i = 2; i <= to; i++)
                {
                    if (ValidatePrimeNumber(i))
                    {
                        sb.Append($"{i}, ");
                    }
                }

                return sb.ToString();

            }*/



          
        }
    }
}


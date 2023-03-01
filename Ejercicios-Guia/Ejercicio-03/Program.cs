/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

Utilizar sentencias de iteración, selectivas y el operador módulo (%).*/
using System;
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string numberString;
            int number;
            bool isPrime;
            bool f = true;          

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

            } while (f);



            static bool ValidatePrimeNumber(int number)            {
                if (number < 2)
                {
                    return false;
                }
                for (int i = 2; i < number; i++)
                {
                   // Console.WriteLine("I {0} NUMERO {1}", i, number);
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            static bool ValidateNumber(string input, double number)
            {

                if (double.TryParse(input, out number))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}


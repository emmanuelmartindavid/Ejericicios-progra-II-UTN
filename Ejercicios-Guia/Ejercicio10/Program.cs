/*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x = true;

            do
            {
                Console.WriteLine("Ingrese dos numeros.");
                if (int.TryParse(Console.ReadLine(), out int number1) && (int.TryParse(Console.ReadLine(), out int number2)))
                {
                   Console.WriteLine($"La suma de {number1} y {number2} es {number2 + number1}");  
                }
                else
                {
                    Console.WriteLine("Ingrese bien los datos.");
                    break;
                }
                Console.WriteLine("Desea continuar?  Ingrese 'S' para salir del programa.");
                if (Validator.ValidateAnswer(Console.ReadLine()))
                {
                    x=false;
                }

            } while (x);

        }

        
    }
}
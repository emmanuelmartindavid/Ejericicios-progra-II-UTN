/*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool confirExit = true;
          
            do
            {
                Console.WriteLine("Ingrese dos numeros.");
                if (int.TryParse(Console.ReadLine(), out int firstOperand) && (int.TryParse(Console.ReadLine(), out int secondOperand)))
                { 
                    Console.WriteLine($"La suma de {firstOperand} y {secondOperand} es {Sum(firstOperand, secondOperand)}");
                }
                else
                {
                    Console.WriteLine("Ingrese bien los datos.");
                    break;
                }
                Console.WriteLine("Desea continuar?  Ingrese 'S' para salir del programa.");
                if (Validator.ValidateAnswer(Console.ReadLine().ToLower()))
                {
                    confirExit = false;
                }

            } while (confirExit);

        }

        static public int Sum(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }


    }
}
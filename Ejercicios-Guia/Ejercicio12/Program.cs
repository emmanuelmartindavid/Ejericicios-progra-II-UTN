/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 

El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. 

Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/
namespace Ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operand = ' ';
            bool keep = true;

            do
            {
                Console.WriteLine("Ingrese primer operando");
                if (decimal.TryParse(Console.ReadLine(), out decimal firstOperand))
                {
                    Console.WriteLine("Ingrese segundo operando");
                    if (decimal.TryParse(Console.ReadLine(), out decimal secondOperand))
                    {
                        Console.WriteLine("Ingrese operacion a realizar. Solo +, -, *, /");

                        operand = Console.ReadKey().KeyChar;

                        if (operand == '+' || operand == '-' || operand == '*' || operand == '/')
                        {
                            Console.WriteLine($"\nResultado: {Calculator.Calculate(firstOperand, secondOperand, operand):#.00}");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese operador valido.");
                        }
                            
                    }
                }

            } while (keep);

        }
    }
}
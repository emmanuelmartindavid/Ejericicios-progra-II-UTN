/*Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.

Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18*/
using System.Text;

namespace Ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero a multiplicar");
            if (int.TryParse(Console.ReadLine(), out int value)) { }
            string table = " ";
            table = Multiplicate(value);
            Console.WriteLine(table);
        }
        public static string Multiplicate(int number)
        {
            int i = 0;
            int result;
            StringBuilder sb = new();
            do
            {
                i++;
                result = number * i;
                sb.AppendLine($"{number} X {i} = {result}");
               
            } while (i < 10);
            return sb.ToString();
        }
    }
}
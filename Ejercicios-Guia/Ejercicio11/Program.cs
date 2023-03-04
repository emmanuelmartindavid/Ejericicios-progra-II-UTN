/*Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.*/
namespace Ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 28;
            int result;
            do
            {
                result = number / 2;

                number -= result;

                Console.WriteLine(result);
            } while (result % 2 == 0 );

            Console.WriteLine("Hello, World!");
        }
    }
}
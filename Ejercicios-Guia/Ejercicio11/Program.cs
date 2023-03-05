/*Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.*/
namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keep = true;
            int number;
            do
            {
                Console.WriteLine("Elija una opcion.\n 1-Decimal a Binario.\n 2-Binario a Decimal.\n 3-Salir.");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un numero a convertir en binario.");
                            if (int.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine($"El numero: {number} es: {Converter.CovertDecimalToBinary(number)} en binario.");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese un numero binario a convertir en decimal.");
                            if (int.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine(Converter.ConvertBinaryToDecimal(number));
                            }
                            break;
                        case 3:
                            keep = false;
                            break;
                    }
                }
            } while (keep);
        }  
    }
}
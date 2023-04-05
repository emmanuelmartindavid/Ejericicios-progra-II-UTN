/*se pide agregar las clases:

NumeroBinario:

Único atributo numero de tipo string.
Único constructor privado (recibe un parámetro de tipo string).
NumeroDecimal:

Único atributo numero de tipo double.
Único constructor privado (recibe un parámetro de tipo double).
Utilizando los métodos de la clase Conversor donde corresponda, agregar las sobrecargas de operadores:

NumeroBinario:

string + (NumeroBinario, NumeroDecimal)
string - (NumeroBinario, NumeroDecimal)
bool == (NumeroBinario, NumeroDecimal)
bool != (NumeroBinario, NumeroDecimal)
NumeroDecimal:

double + (NumeroDecimal, NumeroBinario)
double - (NumeroDecimal, NumeroBinario)
bool == (NumeroDecimal, NumeroBinario)
bool != (NumeroDecimal, NumeroBinario)
Agregar conversiones implícitas para poder ejecutar:

NumeroBinario objBinario = "1001";
NumeroDecimal objDecimal = 9;

Agregar conversiones explícitas para poder ejecutar:

string binario = (string)objBinario;
double numeroDecimal = (double)objDecimal;

Generar el código en el método Main para instanciar un objeto de cada tipo 
y operar entre ellos, imprimiendo cada resultado por pantalla.*/

using Numbers;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BinaryNumber objBinario = "1001";
            DecimalNumber objDecimal = 9;

            string binario = (string)objBinario;
            double numeroDecimal = (double)objDecimal;

            Console.WriteLine("================================================");
            Console.WriteLine($"SOBRECARGA EXPLICITA DE OBJETO BINARIO A STRING: {binario}");
            Console.WriteLine($"SOBRECARGA EXPLICITA DE OBJETO DECIMAL A DOUBLE: {numeroDecimal}");
            Console.WriteLine("================================================");
            Console.WriteLine();
            BinaryNumber binary = "101";
            DecimalNumber decimalNumber = 9;
            bool result3 = binary == decimalNumber;
            bool result4 = binary != decimalNumber;
            double result5 = (double)(decimalNumber + binary);
            double result6 = (double)(decimalNumber - binary);
            bool result7 = decimalNumber == binary;
            bool result8 = decimalNumber != binary;
            Console.WriteLine($"BINARIO == DECIMAL: {result3}");
            Console.WriteLine($"BINARIO != DECIMAL: {result4}");
            Console.WriteLine($"SUMA A DOUBLE: {result5}");
            Console.WriteLine($"RESTA A DOBULE: {result6}");
            Console.WriteLine($"DECIMAL == BINARIO: {result7}");
            Console.WriteLine($"DECIMAL != BINARIO: {result8}");
   
        }
    }
}
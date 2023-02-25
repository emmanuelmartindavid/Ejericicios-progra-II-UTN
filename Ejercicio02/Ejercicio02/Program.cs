//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario,
//mostrar el mensaje: "ERROR. ¡Reingresar número!".
//Utilizar el método Pow de la clase Math para calcular las potencias.
namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double square;
            double qube;
            double number;
            bool conditionNumber;
     
            do
            {

                Console.WriteLine("Ingrese un numero mayor a 0, por favor");
                string numberString = Console.ReadLine();
                double.TryParse(numberString, out number);


                conditionNumber = ValidateNumber(numberString, number);
              

            } while (!conditionNumber || number < 0);

            square = Math.Pow(number, 2);
            qube = Math.Pow(number, 3);
            Console.WriteLine("El cuadrado de {0} es {1}", number, square);
            Console.WriteLine("El cubo de {0} es {1}", number, qube);

        }

        static bool ValidateNumber(string input, double number)
        {
         
            if (double.TryParse(input, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
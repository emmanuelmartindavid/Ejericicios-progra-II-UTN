//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario,
//mostrar el mensaje: "ERROR. ¡Reingresar número!".
//Utilizar el método Pow de la clase Math para calcular las potencias.
namespace Ejercicio_02
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double square;
            double qube;      
            double number;

            do
            {
                Console.WriteLine("Ingrese un numero mayor a 0, por favor");

            } while (!double.TryParse(Console.ReadLine(), out number) || number < 0);

            square = CalculateQube(number);
            qube = CalculateQube(number);    
            Console.WriteLine($"El cuadrado de {number} es {square}");
            Console.WriteLine($"El cubo de {number} es {qube}");

        }

        static public double CalculateSquare(double number)
        {
            return Math.Pow(number, 2);
        }

        static public double CalculateQube(double number)
        {
            return Math.Pow(number, 3);
        }
    }
}
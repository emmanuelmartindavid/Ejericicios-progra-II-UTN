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
            double number = 0;

            do
            {
                Console.WriteLine("Ingrese un numero mayor a 0, por favor");

            } while (!double.TryParse(Console.ReadLine(), out number) || number < 0);

            square = Math.Pow(number, 2);
            qube = Math.Pow(number, 3);
            Console.WriteLine("El cuadrado de {0} es {1}", number, square);
            Console.WriteLine("El cubo de {0} es {1}", number, qube);
        }
    }
}
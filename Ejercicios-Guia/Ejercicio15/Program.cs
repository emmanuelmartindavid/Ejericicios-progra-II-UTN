/*Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.*/
namespace Ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hypotenuse;
            double triangleBase= 3;
            double triangleHeight = 4;

            hypotenuse = Math.Sqrt(Math.Pow(triangleBase, 2) + Math.Pow(triangleHeight, 2));

            Console.WriteLine($"La hipotenusa es: {hypotenuse:#.00}");
        }
    }
}
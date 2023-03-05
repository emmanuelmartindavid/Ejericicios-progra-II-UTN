/*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
namespace Ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Area de cuadrado: {AreaCalculator.CalculateSquareArea(4)} CM2");
            Console.WriteLine($"Area de triangulo: {AreaCalculator.CalculateTriangleArea(4, 9)} CM2");
            Console.WriteLine($"Area de circulo: {AreaCalculator.CalculateCircleArea(6):#.00} CM2");
        }
    }
}
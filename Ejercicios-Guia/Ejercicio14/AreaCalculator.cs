using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
namespace Ejercicio14
{
    public static class AreaCalculator
    {
        public static double CalculateSquareArea(double squaresideLength)
        {
            return squaresideLength * squaresideLength;
        }
        public static double CalculateTriangleArea(double triangleBase, double triagnleHeight)
        {
            return (triangleBase * triagnleHeight) / 2;
        }
        public static double CalculateCircleArea(double radio)
        {
            return Math.PI * radio;
        }
    }
}

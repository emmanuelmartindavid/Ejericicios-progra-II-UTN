using Geometria;

namespace UI_geometria_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //teste Reactngle class
            CortesianPoint vertex1 = new(0, 0);
            CortesianPoint vertex3 = new(5, 5);

            Rectangle rectangle = new(vertex1, vertex3);

            Console.WriteLine("Area: " + rectangle.GetArea());
            Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());

          
        }
    }
}
namespace UI
{

    using System;
    using System.Drawing;

    class Program
    {
        static void Main(string[] args)
        {
           //call the method to draw the fractal tree
            DrawTree(40, 20, 10, 0, 10);
            Console.ReadLine();
         
        }

        //Metho to draw a fractal tree in the console. System.ArgumentOutOfRangeException: 'The value must be greater than or equal to zero and less than the console's buffer size 
        //in that dimension. Parameter name: top'
        public static void DrawTree(int x, int y, int length, double angle, int depth)
        {
            if (depth == 0)
                return;
            int x2 = x + (int)(Math.Cos(angle) * length);
            int y2 = y + (int)(Math.Sin(angle) * length);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
            DrawTree(x2, y2, (int)(length * 0.8), angle + Math.PI / 4, depth - 1);
            DrawTree(x2, y2, (int)(length * 0.8), angle - Math.PI / 4, depth - 1);
        }
        
  
    }
   

}
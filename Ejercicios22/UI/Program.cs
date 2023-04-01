namespace UI
{

    using System;

    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40);
            DrawTree(10, 40, 39, -Math.PI / 2);
            Console.ReadLine();
        }

        static void DrawTree(int depth, int x1, int y1, double angle)
        {
            if (depth == 0) return;

            int x2 = x1 + (int)(Math.Cos(angle) * depth * 10.0);
            int y2 = y1 + (int)(Math.Sin(angle) * depth * 10.0);

            int clampedX1 = Math.Clamp(x1, 0, Console.WindowWidth - 1);
            int clampedY1 = Math.Clamp(y1, 0, Console.WindowHeight - 1);

            Console.SetCursorPosition(clampedX1, clampedY1);
            Console.Write("*");

            DrawLine(x1, y1, x2, y2);

            DrawTree(depth - 1, x2, y2, angle - Math.PI / 4);
            DrawTree(depth - 1, x2, y2, angle + Math.PI / 4);
        }

        static void DrawLine(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double angle = Math.Atan2(y2 - y1, x2 - x1);
            double slope = (y2 - y1) / (double)(x2 - x1);

            for (int i = 1; i <= (int)distance; i++)
            {
                int x = (int)(x1 + i * Math.Cos(angle));
                int y = (int)(y1 + i * Math.Sin(angle) * slope);

                int clampedX = Math.Clamp(x, 0, Console.WindowWidth - 1);
                int clampedY = Math.Clamp(y, 0, Console.WindowHeight - 1);

                Console.SetCursorPosition(clampedX, clampedY);
                Console.Write("#");
            }
        }
    }

}
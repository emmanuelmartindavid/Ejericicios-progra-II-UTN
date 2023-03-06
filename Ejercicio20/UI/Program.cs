using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor color = ConsoleColor.Blue;
            string draw;
            
            Boligrafo blueInk = new(color, 100);

            if(blueInk.DrawShape(500, out draw))
            {
                Console.ForegroundColor = blueInk.GetColor();
                Console.WriteLine(draw);
            }
        }
    }
}
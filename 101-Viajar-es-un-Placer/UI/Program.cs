using Logic;
using System.Drawing;
using System;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Truck camioncito = new(8, 2, Colors.Blue, 8, 5000);
            Console.WriteLine(camioncito);
            Console.WriteLine("--------------");
            Automobile autito = new(4, 5, Colors.White, 5, 3);
            Console.WriteLine(autito);
            Console.WriteLine("-----------");
            Motorcycle motito = new(2, Colors.Red, 1000);
            Console.WriteLine(motito);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Input
    {
        public static string LoadName()
        {
            string input;
            Console.WriteLine("Ingrese su nombre: ");
            input = Console.ReadLine();
            input[1].ToString().ToUpper();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                return LoadName();
            }
            return input.Trim();
        }

        public static int[] LoadKilometers()
        {
            int[] kilometers = new int[7];

            Console.WriteLine("Ingrese los kilometros: ");
            for (int i = 0; i < kilometers.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), out int input))
                {
                    return LoadKilometers();
                }
                kilometers[i] = input;

            }
            return kilometers;
        }
    }
}

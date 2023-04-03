using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic
{
    public static class Input
    {

        //Method to validate a string input with a minimum length, maximus lenght. it does not accept spetial characters either
        public static string ValidateString(string message, int min, int max)
        {
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();

            } while (string.IsNullOrEmpty(input) || input.Length < min || input.Length > max || !Regex.IsMatch(input, @"^[a-zA-Z]+$"));
            //i want to return always the first of input letter in uppercase
            input = input.First().ToString().ToUpper() + input.Substring(1);
            return input;
        }

        //Method to validate a DateTime birth day of the pet. with the date format: dd/mm/yyyy
        public static DateTime ValidateDate(string message)
        {
            DateTime input;
            do
            {
                Console.WriteLine(message);

            } while (!(DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out input))
                        || input > DateTime.Now);

            return input;
        }


        //Method to validate an adress street. it allows to use numbers and letters. 
        public static string ValidateAdress(string message)
        {
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, @"^[a-zA-Z0-9\s]+$"));
            return input;
        }

        //Method to validate a phone number. it allows to use numbers and the + sign.
        public static string ValidatePhoneNumber(string message)
        {
            string input;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, @"^[0-9+]+$"));
            return input;
        }

        public static bool ValidateAnswer(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower() == "s";
        }


    }
}

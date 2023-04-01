using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    static class Converter
    {
        public static string CovertDecimalToBinary(int number)
        {
            string binary = "";

            while (number > 0)
            {
                int rest = number % 2;
                binary = rest + binary;
                number /= 2;
            }
            return binary;
        }
        public static int ConvertBinaryToDecimal(int number)
        {
            int decimalNumber = 0;
            int baseNumber = 1;

            while (number > 0)
            {
                int digit = number % 10;
                decimalNumber += digit * baseNumber;
                number /= 10;
                baseNumber *= 2;
            }
            return decimalNumber;
        }

        public static string ShowDataConverted(int option, int number)
        {
            StringBuilder sb = new StringBuilder();

            if (option == 1)
            {
                sb.AppendLine($"El numero: {number} es: {CovertDecimalToBinary(number)} en binario.");
            }
            else if (option == 2) 
            {
                sb.AppendLine($"El numero binario: {number} es: {ConvertBinaryToDecimal(number)} en decimal.");
            }

            return sb.ToString();
        }
    }
}

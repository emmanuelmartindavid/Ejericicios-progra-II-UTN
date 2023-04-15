using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Converter
    {
        public static string ConvertDecimalToBinary(double number)
        {
            return Convert.ToString((int)number, 2);
        }
        public static double ConvertBinaryToDecimal(string number)
        {
            return Convert.ToInt32(number, 2);
        }
    }
}

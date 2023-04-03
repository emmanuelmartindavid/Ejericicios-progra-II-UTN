using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Converter
    {
        //methods to convert from decimal to binary and viceversa
        public static string ConvertDecimalToBinary(double number)
        {
            return Convert.ToString((int)number, 2);
        }
        public static double ConvertBinaryToDecimal(string number)
        {
            return Convert.ToInt32(number, 2);
        }



      /*  public int ConvertBinaryToDecimal(string binary)
        {
            int result = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                result += (int)Math.Pow(2, binary.Length - 1 - i) * (binary[i] - '0');
            }
            return result;
        }*/

    }
}

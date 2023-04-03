using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class BinaryNumber
    {
        public string number;
         //Constructor
        private BinaryNumber(string number)
        {
            this.number = number;
        }
        //implicit and explicit conversion
        public static implicit operator BinaryNumber(string number)
        {
            return new BinaryNumber(number);
        }
        public static explicit operator string(BinaryNumber binary)
        {
            return binary.number;
        }

        //Overload operator + , - , == , !=
        public static BinaryNumber operator +(BinaryNumber binary, DecimalNumber decimalNumber)
        {
            double number = Converter.ConvertBinaryToDecimal(binary.number) + decimalNumber.number;

            return Converter.ConvertDecimalToBinary(number);
        }
        public static BinaryNumber operator -(BinaryNumber binary, DecimalNumber decimalNumber)
        {
            double number = Converter.ConvertBinaryToDecimal(binary.number) - decimalNumber.number;
            return Converter.ConvertDecimalToBinary(number);
        }
      
        public static bool operator !=(BinaryNumber binary, DecimalNumber decimalNumber)
        {
            return !((string)binary == Converter.ConvertDecimalToBinary(decimalNumber.number));
        }

        public static bool operator ==(BinaryNumber binary, DecimalNumber decimalNumber)
        {
            return (string)binary == Converter.ConvertDecimalToBinary(decimalNumber.number);
        }


        
       
    }
}

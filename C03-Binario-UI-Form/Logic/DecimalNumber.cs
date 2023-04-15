using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class DecimalNumber
    {
        public double number;
        private DecimalNumber(double number)
        {
            this.number = number;
        }
        public static implicit operator DecimalNumber(double number)
        {
            return new DecimalNumber(number);
        }
        public static explicit operator DecimalNumber(BinaryNumber binaryNumber)
        {
            return new DecimalNumber(Converter.ConvertBinaryToDecimal(binaryNumber.number));
        }
    }
}

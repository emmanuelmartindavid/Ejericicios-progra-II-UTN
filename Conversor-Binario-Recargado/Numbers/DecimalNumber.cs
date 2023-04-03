namespace Numbers
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
        public static explicit operator double(DecimalNumber decimalNumber)
        {
            return decimalNumber.number;
        }

        public static DecimalNumber operator +(DecimalNumber decimalNumber, BinaryNumber binary)
        {
            double number = decimalNumber.number + Converter.ConvertBinaryToDecimal(binary.number);
            return number;
        }
     
        public static DecimalNumber operator -(DecimalNumber decimalNumber, BinaryNumber binary)
        {
            double number = decimalNumber.number - Converter.ConvertBinaryToDecimal(binary.number);
            return number;
        }

        public static bool operator !=(DecimalNumber decimalNumber, BinaryNumber binary)
        {
            return !((double)decimalNumber == Converter.ConvertBinaryToDecimal(binary.number));
        }

        public static bool operator ==(DecimalNumber decimalNumber, BinaryNumber binary)
        {
            return (double)decimalNumber == Converter.ConvertBinaryToDecimal(binary.number);
        }
    }
}
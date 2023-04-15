namespace Logic
{
    public class BinaryNumber
    {
        public string number;

        private BinaryNumber(string number)
        {
            this.number = number;
        }


        public static implicit operator BinaryNumber(string number)
        {
            return new BinaryNumber(number);
        }


        public static explicit operator BinaryNumber(DecimalNumber decimalNumber)
        {
            return new BinaryNumber(Converter.ConvertDecimalToBinary(decimalNumber.number));
        }

    }
}
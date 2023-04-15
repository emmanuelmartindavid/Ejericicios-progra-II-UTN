using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class InputNumberValidator
    {
     
        public static void ValidateInputString(string number)
        {
        
            foreach (char c in number!)
            {
                if ( c != '0' && c != '1')
                {
                    throw new InvalidInputException();
                }
            }
           
        }
        public static string GetValidatedString(string number)
        {
            ValidateInputString(number);
            return number;         
        }
        public static void ValidateInputDecimal(string number)
        {
            foreach (char c in number!)
            {
                if (c < 0 && c > 9)
                {
                    throw new InvalidInputException();
                }
            }

        }

        public static double GetValidatedDecimal(string number)
        {
            ValidateInputDecimal(number);
            return double.Parse(number);
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class InputDegreeValidator
    {

        public static void ValidateInputDegree(string inputDegree)
        {
            if (!decimal.TryParse(inputDegree, out _))
            {
                throw new InvalidInputException();
            }
          
        }

        public static decimal ConvertInputDegreeToDecimal(string inputDegree)
        {
            ValidateInputDegree(inputDegree);
         
         
            decimal degree = decimal.Parse(inputDegree);
            return degree;
        }


    }
}

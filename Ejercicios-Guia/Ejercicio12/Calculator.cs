using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public static class Calculator
    {

        public static decimal Calculate(decimal firstOperand, decimal secondOperand, char operation)
        {
            decimal result = 0;

            if (operation == '+')
            { result = firstOperand + secondOperand; }
            if (operation == '-')
            { result = firstOperand - secondOperand; }
            if (operation == '*')
            { result = firstOperand * secondOperand; }
            if (operation == '/')
            {
                if (ValidateDivider(secondOperand))
                {
                    result = firstOperand / secondOperand;
                }
            }
            return result;
        }

        private static bool ValidateDivider(decimal divider)
        {
            if (divider == 0) return false;
            return true;
        }
    }
}

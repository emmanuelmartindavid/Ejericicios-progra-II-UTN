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
            { result = firstOperand / secondOperand; }
            return result;
        }

        private static bool ValidateDivider(decimal divider)
        {
            if (divider == 0)
            {
                return false;
            }
            return true;
        }

        public static string ShowDataCalculator(decimal firstOperand, decimal secondOperand, char operation)
        {
            StringBuilder sb = new StringBuilder();

            switch (operation)
            {
                case '+':
                    sb.AppendLine($"La suma de: {firstOperand} y {secondOperand} es {Calculate(firstOperand, secondOperand, operation):#.00}");
                    break;
                case '-':
                    sb.AppendLine($"La resta de: {firstOperand} y {secondOperand} es {Calculate(firstOperand, secondOperand, operation):#.00}");
                    break;
                case '*':
                    sb.AppendLine($"La multiplicacion de: {firstOperand} y {secondOperand} es {Calculate(firstOperand, secondOperand, operation):#.00}");
                    break;
                case '/':
                    if (ValidateDivider(secondOperand))
                    {
                        sb.AppendLine($"La division de: {firstOperand} y {secondOperand} es {Calculate(firstOperand, secondOperand, operation):#.00}");
                    }
                    else
                    {
                        sb.AppendLine("NO ES POSIBLE DIVIDIR POR 0!");
                    }
                    break;
            }
            return sb.ToString();
        }
    }
}

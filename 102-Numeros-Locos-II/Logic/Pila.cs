using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Pila
    {

        private static Stack<int> OrderStack(Stack<int> stackNumbers, bool state)
        {
            Stack<int> filteredStack = new(state ? stackNumbers.Where(n => n > 0).OrderBy(n => n) : stackNumbers.Where(n => n < 0).OrderBy(n => -n));

          
            return filteredStack;
        }


        public static string ShowStackData()
        {
            StringBuilder sb = new();
            Stack<int> stackNumbers = new(Number.GetRandomCollection());
            string decreasingStack = string.Join("\n", OrderStack(stackNumbers, true));
            string increasingStack = string.Join("\n", OrderStack(stackNumbers, false));


            sb.AppendLine($"ORDEN DE NUMEROS POSITIVOS DE STACK DE FORMA DECRECIENTE:\n{decreasingStack}");
            sb.AppendLine("[=======================================================]");
            sb.AppendLine($"ORDEN DE NUMEROS NEGATIVOS DE STACK DE FORMA CRECIENTE:\n{increasingStack}");


            return sb.ToString();
        }
    }
}

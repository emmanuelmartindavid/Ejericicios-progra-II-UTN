using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Cola
    {

        private static Queue<int> OrderQueue(Queue<int> queueNumbers, bool state)
        {
            Queue<int> filteredQueue = new(state ? queueNumbers.Where(n => n > 0).OrderBy(n => -n) : queueNumbers.Where(n => n < 0).OrderBy(n => n));
            return filteredQueue;
        }

        public static string ShowQueueData()
        {
            StringBuilder sb = new();
            Queue<int> queueNumbers = new(Number.GetRandomCollection());
            string decreasingQueue = string.Join("\n", OrderQueue(queueNumbers, true));
            string increasingQueue = string.Join("\n", OrderQueue(queueNumbers, false));

            sb.AppendLine($"ORDEN DE NUMEROS POSITIVOS DE COLA DE FORMA DECRECIENTE:\n{decreasingQueue}");
            sb.AppendLine("[=======================================================]");
            sb.AppendLine($"ORDEN DE NUMEROS NEGATIVOS DE COLA DE FORMA CRECIENTE:\n{increasingQueue}");

            return sb.ToString();
        }
    }
}

using System;
using System.Text;

namespace Logic
{
    public static class Lista
    {
        private static List<int> OrderList(List<int> listNumbers, bool state)
        {
            List<int> filteredList = new(state ? listNumbers.Where(n => n > 0).OrderBy(n => -n) : listNumbers.Where(n => n < 0).OrderBy(n => n));
            return filteredList;
        }

        public static string ShowListData()
        {
            StringBuilder sb = new();
            List<int> listNumbers = new(Number.GetRandomCollection());
            string decreasingList = string.Join("\n", OrderList(listNumbers, true));
            string increasingList = string.Join("\n", OrderList(listNumbers, false));

            sb.AppendLine($"ORDEN DE NUMEROS POSITIVOS DE LISTA DE FORMA DECRECIENTE:\n{decreasingList}");
            sb.AppendLine("[=======================================================]");
            sb.AppendLine($"ORDEN DE NUMEROS NEGATIVOS DE LISTA DE FORMA CRECIENTE:\n{increasingList}");

            return sb.ToString();
        }
    }
}
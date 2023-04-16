using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Logic
{
    public static class HandlerWord
    {
   
        public static Dictionary<string, int> AddWordsToDictionary(string text)
        {
            Dictionary<string, int> dictionary = new();
            string[] words = Regex.Replace(text, @"[^\w\s]", "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++;
                }
            }
            return dictionary;
        }

        public static Dictionary<string, int> OrderWordsByFrequency(Dictionary<string, int> dictionary)
        {
            return dictionary.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public static Dictionary<string, int> GetTopThreeWordsByFrequency(Dictionary<string, int> dictionary, int top)
        {
            Dictionary<string, int> topWords = new Dictionary<string, int>();
            foreach (var word in OrderWordsByFrequency(dictionary))
            {
                if (topWords.Count == top)
                {
                    break;
                }
                topWords.Add(word.Key, word.Value);
            }
            return topWords;
        }

        public static string ShowTopNWordsByFrequency(Dictionary<string, int> dictionary, int top)
        {
            Dictionary<string, int> topWords = GetTopThreeWordsByFrequency(dictionary, top);
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine($"TOP {top} PALABRAS MAS REPETIDAS:");
            foreach (var word in topWords)
            {
                stringBuilder.AppendLine($"Palabra: {word.Key} - Cantidad: {word.Value}");
            }
            return stringBuilder.ToString();
        }

    }
}
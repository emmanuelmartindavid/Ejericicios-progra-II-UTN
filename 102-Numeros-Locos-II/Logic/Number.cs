using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Number
    {
        public static ICollection<int> GetRandomCollection()
        {
            Random random = new();
            ICollection<int> collection = new List<int>();

            while (collection.Count < 20)
            {
                int number = random.Next(-100, 100);

                if (!collection.Contains(number) && number != 0)
                {
                    collection.Add(number);
                }
            }
            return collection;
        }
    }
}

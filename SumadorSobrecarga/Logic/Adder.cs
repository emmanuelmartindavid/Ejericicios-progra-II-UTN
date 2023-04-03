using System.Diagnostics.Contracts;

namespace Logic
{
    public class Adder
    {
        public int sumCount;

        public Adder(int a)
        {
            this.sumCount = a;
        }

        public Adder() : this(0)
        { }

        public long Add(long a, long b)
        {
            this.sumCount++;
            return a + b;
        }

        public string Add(string a, string b)
        {
            this.sumCount++;
            return a + b;
        }

        public int CountSum()
        {
            return this.sumCount;
        }

        public static explicit operator int(Adder a)
        {
            return a.sumCount;
        }

        public static long operator +(Adder a, Adder b)
        {
            return a.sumCount + b.sumCount;
        }

        public static bool operator |(Adder a, Adder b)
        {
            return a.sumCount == b.sumCount;
        }
    }
}
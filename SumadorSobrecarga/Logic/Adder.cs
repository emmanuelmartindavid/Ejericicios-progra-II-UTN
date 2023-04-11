using System.Diagnostics.Contracts;

namespace Logic
{
    public class Adder
    {
        private int _sumCount;

        public Adder(int a)
        {
            this._sumCount = a;
        }

        public Adder() : this(0)
        { }

        public long Add(long a, long b)
        {
            this._sumCount++;
            return a + b;
        }

        public string Add(string a, string b)
        {
            this._sumCount++;
            return a + b;
        }

        public int CountSum()
        {
            return this._sumCount;
        }

        public static explicit operator int(Adder a)
        {
            return a._sumCount;
        }

        public static long operator +(Adder a, Adder b)
        {
            return a._sumCount + b._sumCount;
        }

        public static bool operator |(Adder a, Adder b)
        {
            return a._sumCount == b._sumCount;
        }
    }
}
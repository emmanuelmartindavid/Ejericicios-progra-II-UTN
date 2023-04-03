using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    public class Dolar
    {
        private double _amount;
        static double _dollarExchRate;

        public Dolar()
        {
            _dollarExchRate = 1;
        }

        public Dolar(double amount)
        {
            _amount = amount;
        }

        public Dolar(double amount, double Rate) : this(amount)
        {
            _dollarExchRate = Rate;
        }


        public double GetAmount()
        {
            return _amount;
        }

        public static double GetRate()
        {
            return _dollarExchRate;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d._amount * Euro.GetRate());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d._amount * Peso.GetRate());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        //i need to add the implicit and explicit operators for the other classes
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d._amount + ((Dolar)e)._amount);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d._amount + ((Dolar)p)._amount);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d._amount - ((Dolar)e)._amount);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d._amount - ((Dolar)p)._amount);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d._amount == ((Dolar)e)._amount;
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d._amount == ((Dolar)p)._amount;
        }
        public static bool operator ==(Dolar a, Dolar b)
        {
            return a._amount == b._amount;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return d._amount != ((Dolar)e)._amount;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return d._amount != ((Dolar)p)._amount;
        }
        public static bool operator !=(Dolar a, Dolar b)
        {
            return a._amount != b._amount;
        }

    }
}

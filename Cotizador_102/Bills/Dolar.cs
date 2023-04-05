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
        public double Amount { get => _amount;  set => _amount = value; }
        private static double _dollarExchRate;

        public Dolar()
        {
            _dollarExchRate = 1;
        }

        public Dolar(double amount)
        {
            Amount = amount;
        }

        public Dolar(double amount, double Rate) : this(amount)
        {
            _dollarExchRate = Rate;
        }


        public double GetAmount()
        {
            return Amount;
        }

        public static double GetRate()
        {
            return _dollarExchRate;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.Amount * Euro.GetRate());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.Amount * Peso.GetRate());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        //i need to add the implicit and explicit operators for the other classes
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.Amount + ((Dolar)e)._amount);
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.Amount + ((Dolar)p)._amount);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.Amount - ((Dolar)e).Amount);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.Amount - ((Dolar)p).Amount);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return d.Amount == ((Dolar)e).Amount;
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return d.Amount == ((Dolar)p).Amount;
        }
        public static bool operator ==(Dolar a, Dolar b)
        {
            return a.Amount == b.Amount;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator !=(Dolar a, Dolar b)
        {
            return !(a == b);
        }

    }
}

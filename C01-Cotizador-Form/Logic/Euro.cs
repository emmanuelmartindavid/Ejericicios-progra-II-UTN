using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Euro
    {
        private double _amount;
        public double Amount { get => _amount; set => _amount = value; }
        private static double _dollarExchRate;

        static Euro()
        {
            _dollarExchRate = 1 / 1.09;
        }
        public Euro(double amount)
        {
            Amount = amount;
        }

        public Euro(double amount, double Rate) : this(amount)
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
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.Amount / _dollarExchRate);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.Amount + ((Euro)d).Amount);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.Amount + ((Euro)p).Amount);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.Amount - ((Euro)d).Amount);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.Amount - ((Euro)p).Amount);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.Amount == ((Euro)d).Amount;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e.Amount == ((Euro)p).Amount;
        }
        public static bool operator ==(Euro e, Euro p)
        {
            return e.Amount == p.Amount;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e, Euro p)
        {
            return !(e == p);
        }
    }
}

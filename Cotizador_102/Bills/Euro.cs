using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    public class Euro
    {
        private double _amount;
        static double _dollarExchRate;

        public Euro()
        {
            _dollarExchRate = 1 / 1.09;
        }
        public Euro(double amount)
        {
            _amount = amount;
        }

        public Euro(double amount, double Rate) : this(amount)
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
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e._amount / _dollarExchRate);
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
            return new Euro(e._amount + ((Euro)d)._amount);
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e._amount + ((Euro)p)._amount);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e._amount - ((Euro)d)._amount);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e._amount - ((Euro)p)._amount);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return e._amount == ((Euro)d)._amount;
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return e._amount == ((Euro)p)._amount;
        }
        public static bool operator ==(Euro e, Euro p)
        {
            return e._amount == p._amount;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return e._amount != ((Euro)d)._amount;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return e._amount != ((Euro)p)._amount;
        }

        public static bool operator !=(Euro e, Euro p)
        {
            return e._amount != p._amount;
        }
    }
}

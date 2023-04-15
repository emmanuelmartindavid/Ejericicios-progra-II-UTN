using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Peso
    {
        private double _amount;
        public double Amount { get => _amount; set => _amount = value; }
        private static double _dollarExchRate;

        public Peso()
        {
            _dollarExchRate = 1 / 66;
        }

        public Peso(double amount)
        {
            Amount = amount;
        }

        public Peso(double amount, double Rate) : this(amount)
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

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.Amount / Peso.GetRate());
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.Amount + ((Peso)d).Amount);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.Amount + ((Peso)e).Amount);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.Amount - ((Peso)d).Amount);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.Amount - ((Peso)e).Amount);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.Amount == ((Peso)d).Amount;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p.Amount == ((Peso)e).Amount;
        }

        public static bool operator ==(Peso a, Peso b)
        {
            return a.Amount == b.Amount;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator !=(Peso a, Peso b)
        {
            return !(a == b);
        }
    }
}

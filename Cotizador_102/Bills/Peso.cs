namespace Bills
{
    public class Peso
    {
        private double _amount;
        static double _dollarExchRate;

        public Peso()
        {
            _dollarExchRate = 1 / 210;
        }

        public Peso(double amount)
        {
            _amount = amount;
        }

        public Peso(double amount, double Rate) : this(amount)
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

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p._amount / Peso.GetRate());
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p._amount + ((Peso)d)._amount);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p._amount + ((Peso)e)._amount);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p._amount - ((Peso)d)._amount);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p._amount - ((Peso)e)._amount);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p._amount == ((Peso)d)._amount;
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p._amount == ((Peso)e)._amount;
        }

        public static bool operator ==(Peso a, Peso b)
        {
            return a._amount == b._amount;
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return p._amount != ((Peso)d)._amount;
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return p._amount != ((Peso)e)._amount;
        }

        public static bool operator !=(Peso a, Peso b)
        {
            return a._amount != b._amount;
        }

    }
}
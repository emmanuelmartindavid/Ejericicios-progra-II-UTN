using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dregrees
{
    public class Celsius
    {
        private decimal _celsiusDegree;
        public decimal CelsiusDegree { get => _celsiusDegree; set => _celsiusDegree = value; }

        public Celsius(decimal degree) 
        {
            CelsiusDegree = degree;
        }

        public static implicit operator Celsius(decimal decimalDegree)
        {
            return new Celsius(decimalDegree);
        }
        public static Celsius operator +(Celsius celsiusDegree, Kelvin kelvinDegree)
        {
            return new Celsius(celsiusDegree.CelsiusDegree + Converter.ConvertKelvinToCelsius(kelvinDegree.KelvinDegree));
        }
        public static Celsius operator +(Celsius celsiusDegree, Fahrenheit faherenheitDegree)
        {
            return new Celsius(celsiusDegree.CelsiusDegree + Converter.ConvertFahrenheitToCelsius(faherenheitDegree.FahrenheitDegree));
        }

        public static Celsius operator -(Celsius celsiusDegree, Kelvin kelvinDegree)
        {
            return new Celsius(celsiusDegree.CelsiusDegree - Converter.ConvertKelvinToCelsius(kelvinDegree.KelvinDegree));
        }
        public static Celsius operator -(Celsius celsiusDegree, Fahrenheit faherenheitDegree)
        {
            return new Celsius(celsiusDegree.CelsiusDegree - Converter.ConvertFahrenheitToCelsius(faherenheitDegree.FahrenheitDegree));
        }

    }
}

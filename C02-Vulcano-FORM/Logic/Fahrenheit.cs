using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Fahrenheit
    {

        private decimal _fahrenheitDegree;
        public decimal FahrenheitDegree { get => _fahrenheitDegree; set => _fahrenheitDegree = value; }

        public Fahrenheit(decimal fahrenheitDegree)
        {
            FahrenheitDegree = fahrenheitDegree;
        }

        public static explicit operator Fahrenheit(Celsius celsius)
        {
            return new Fahrenheit(Converter.ConvertCelciusToFahrenheit(celsius.CelsiusDegree));
        }

        public static explicit operator Fahrenheit(Kelvin kelvin)
        {
            return new Fahrenheit(Converter.ConvertKelvintoFahrenheit(kelvin.KelvinDegree));
        }

        public static implicit operator Fahrenheit(decimal fahrenheitDegree)
        {
            return new Fahrenheit(fahrenheitDegree);
        }

        public static Fahrenheit operator +(Fahrenheit fahrenheitdegree, Celsius celsiusDegree)
        {
            return new Fahrenheit(fahrenheitdegree.FahrenheitDegree + Converter.ConvertCelciusToFahrenheit(celsiusDegree.CelsiusDegree));
        }

        public static Fahrenheit operator +(Fahrenheit fahrenheitdegree, Kelvin kelvinDegree)
        {
            return new Fahrenheit(fahrenheitdegree.FahrenheitDegree + Converter.ConvertKelvintoFahrenheit(kelvinDegree.KelvinDegree));
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheitdegree, Celsius celsiusDegree)
        {
            return new Fahrenheit(fahrenheitdegree.FahrenheitDegree - Converter.ConvertCelciusToFahrenheit(celsiusDegree.CelsiusDegree));
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheitdegree, Kelvin kelvinDegree)
        {
            return new Fahrenheit(fahrenheitdegree.FahrenheitDegree - Converter.ConvertKelvintoFahrenheit(kelvinDegree.KelvinDegree));
        }
    }
}

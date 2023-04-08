using System.Net.Http.Headers;

namespace Dregrees
{
    public class Fahrenheit
    {
        private decimal _fahrenheitDegree;
        public decimal FahrenheitDegree { get => _fahrenheitDegree; set => _fahrenheitDegree = value; }

        public Fahrenheit(decimal fahrenheitDegree)
        {
            FahrenheitDegree = fahrenheitDegree;
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
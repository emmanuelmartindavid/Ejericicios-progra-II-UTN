using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Kelvin
    {
        private decimal _kelvinDegree;
        public decimal KelvinDegree { get => _kelvinDegree; set => _kelvinDegree = value; }


        public Kelvin(decimal kelvinDegree)
        {
            KelvinDegree = kelvinDegree;
        }

        public static explicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(Converter.ConvertCelciusToKelvin(celsius.CelsiusDegree));
        }

        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return new Kelvin(Converter.ConvertFahrenheitToKelvin(fahrenheit.FahrenheitDegree));
        }

        public static implicit operator Kelvin(decimal kelvinDegree)
        {
            return new Kelvin(kelvinDegree);
        }

        public static Kelvin operator +(Kelvin kelvinDegree, Celsius celciusDegree)
        {
            return new Kelvin(kelvinDegree.KelvinDegree + Converter.ConvertCelciusToKelvin(celciusDegree.CelsiusDegree));
        }
        public static Kelvin operator +(Kelvin kelvinDegree, Fahrenheit faherenheitDegree)
        {
            return new Kelvin(kelvinDegree.KelvinDegree + Converter.ConvertFahrenheitToKelvin(faherenheitDegree.FahrenheitDegree));
        }

        public static Kelvin operator -(Kelvin kelvinDegree, Celsius celciusDegree)
        {
            return new Kelvin(kelvinDegree.KelvinDegree - Converter.ConvertCelciusToKelvin(celciusDegree.CelsiusDegree));
        }
        public static Kelvin operator -(Kelvin kelvinDegree, Fahrenheit faherenheitDegree)
        {
            return new Kelvin(kelvinDegree.KelvinDegree - Converter.ConvertFahrenheitToKelvin(faherenheitDegree.FahrenheitDegree));
        }

    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dregrees
{
    public static class Converter
    {
        public static decimal ConvertCelciusToFahrenheit(decimal celsiusDegree)
        {
            return celsiusDegree * (9 / 5m) + 32;
        }
        public static decimal ConvertFahrenheitToCelsius(decimal fahrenheitDegree)
        {
            return (fahrenheitDegree - 32) * 5 / 9m;
        }
        public static decimal ConvertKelvintoFahrenheit(decimal kelvintoDegree)
        {
            return (kelvintoDegree * 9 / 5m) - 459.67m;
        }
        public static decimal ConvertFahrenheitToKelvin(decimal fahrenheitDegree)
        {
            return (fahrenheitDegree + 459.67m) * 5 / 9;
        }

        public static decimal ConvertCelciusToKelvin(decimal celsiusDegree)
        {
            return celsiusDegree + 273.15m;
        }
        public static decimal ConvertKelvinToCelsius(decimal kelvinDegree)
        {
            return kelvinDegree - 273.15m;
        }

        internal static decimal ConvertCelciusToKelvin(object celciusDegree)
        {
            throw new NotImplementedException();
        }
    }
}

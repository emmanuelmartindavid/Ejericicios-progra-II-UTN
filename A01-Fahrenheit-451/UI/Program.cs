using Dregrees;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvinDegree = new(1);
            Celsius celsiusDegree = new(1);
            Fahrenheit fahrenheitDegree = new(1);

            Kelvin auxKelvin = kelvinDegree + celsiusDegree;
            Console.WriteLine($"{kelvinDegree.KelvinDegree} KELVIN + {celsiusDegree.CelsiusDegree} CELSIUS = {auxKelvin.KelvinDegree:#.000} KELVIN");

            auxKelvin = kelvinDegree + fahrenheitDegree;
            Console.WriteLine($"{kelvinDegree.KelvinDegree} KELVIN + {fahrenheitDegree.FahrenheitDegree} FAHRENHEIT = {auxKelvin.KelvinDegree:#.000} KELVIN");
           
            Console.WriteLine();
            Console.WriteLine("<===================================================>");
            Console.WriteLine();

            Celsius auxCelsius = celsiusDegree + kelvinDegree;
            Console.WriteLine($"{celsiusDegree.CelsiusDegree} CELSIUS + {kelvinDegree.KelvinDegree} KELVIN = {auxCelsius.CelsiusDegree:#.000} CELSIUS");

            auxCelsius = celsiusDegree + fahrenheitDegree;
            Console.WriteLine($"{celsiusDegree.CelsiusDegree} CELSIUS + {fahrenheitDegree.FahrenheitDegree} FAHRENHEIT = {auxCelsius.CelsiusDegree:#.000} CELSIUS");

            Console.WriteLine();
            Console.WriteLine("<===================================================>");
            Console.WriteLine();

            Fahrenheit auxFahrenheit = fahrenheitDegree + celsiusDegree;
            Console.WriteLine($"{fahrenheitDegree.FahrenheitDegree} FAHRENHEIT + {celsiusDegree.CelsiusDegree} CELSIUS = {auxFahrenheit.FahrenheitDegree:#.000} FAHRENHEIT");

            auxFahrenheit = fahrenheitDegree + kelvinDegree;
            Console.WriteLine($"{fahrenheitDegree.FahrenheitDegree} FAHRENHEIT + {kelvinDegree.KelvinDegree} KELVIN = {auxFahrenheit.FahrenheitDegree:#.000} FAHRENHEIT");

            Console.WriteLine();
            Console.WriteLine("<===================================================>");
            Console.WriteLine();



        }
    }
}
/*Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) 
y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/


using System.Globalization;

namespace Ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese una fecha (formato dd/MM/yyyy):");

            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                if ((date.CompareTo(DateTime.Now) == 1))
                {
                    Console.WriteLine("No puede ingresar una fecha futura!");
                }
                else
                {
                    Console.WriteLine(CalculateDays(date));
                }

            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }
        }

        public static DateTime CalculateDays(DateTime date)
        {
            int year = 365;
            int days;

           days = DateTime.DaysInMonth(date.Year,date.Month);
            Console.WriteLine(days);

            if (ValidateLeapYear(date))
            {

            }
            return date;
        }

        public static bool ValidateLeapYear(DateTime date)
        {
            if (date.Year % 4 == 0 && (date.Year % 100 != 0 || date.Year % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
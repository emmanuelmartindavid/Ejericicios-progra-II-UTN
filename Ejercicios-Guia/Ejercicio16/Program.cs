/*Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) 
y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.*/


using System.Globalization;
using System.Linq.Expressions;

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
                    Console.WriteLine(DaysSinceDate(date));
                }

            }
            else
            {
                Console.WriteLine("La fecha ingresada no es válida.");
            }
        }

        public static int DaysSinceDate(DateTime date)
        {
            TimeSpan timeSpan = DateTime.Now - date;
            int days = timeSpan.Days;

            int leapYears = (date.Year % 4 == 0 && (date.Year % 100 != 0 || date.Year % 400 == 0)) ? 1 : 0;
            int leapDays = leapYears * (DateTime.IsLeapYear(DateTime.Now.Year) ? 1 : 0);

            return days - leapDays;
        }


      /*  public static bool ValidateLeapYear(DateTime date)
        {
            if (date.Year % 4 == 0 && (date.Year % 100 != 0 || date.Year % 400 == 0))
            {
                return true;
            }
            return false;
        }*/
    }
}



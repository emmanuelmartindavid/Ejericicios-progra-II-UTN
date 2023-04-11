/*
Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.
 */
using Logic;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car a1 = new(1, "escu1");
            Car a2 = new(4, "escu2");
            Car a3 = new(5, "escu3");
            Car a4 = new(1, "escu1");
            Car a5 = new(2, "escu4");
            Race competencia = new(5, 5);



            if (competencia + a1)
            {
                Console.WriteLine(competencia.ShowDataRace());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a2)
            {
                Console.WriteLine(competencia.ShowDataRace());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a3)
            {
                Console.WriteLine(competencia.ShowDataRace());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine(competencia.ShowDataRace());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a5)
            {
                Console.WriteLine(competencia.ShowDataRace());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}
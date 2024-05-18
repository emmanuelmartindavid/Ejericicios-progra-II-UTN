using Logic;
using System.Diagnostics;

namespace UI
{
    internal class Program
    {
        static void Main()
        {
            Formula1Car a1 = new(1, "escu1",4);
            Formula1Car a2 = new(4, "escu2",4);
            Formula1Car a3 = new(5, "escu3",3);
            Formula1Car a4 = new(1, "escu1",7);
            Formula1Car a5 = new(2, "escu4",2);
            Race competencia = new(5, 5, RaceType.Formula1);



            if (competencia + a1)
            {
                Console.WriteLine(competencia.ShowRaceData());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a2)
            {
                Console.WriteLine(competencia.ShowRaceData());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a3)
            {
                Console.WriteLine(competencia.ShowRaceData());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a4)
            {
                Console.WriteLine(competencia.ShowRaceData());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            if (competencia + a5)
            {
                Console.WriteLine(competencia.ShowRaceData());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
        }
    }
}
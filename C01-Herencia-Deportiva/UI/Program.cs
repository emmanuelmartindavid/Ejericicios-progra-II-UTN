using Logic;
using System.Numerics;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Team team = new(3, "PATRONATO");
            Player player1 = new(213, "Ismael", 5, 20);
            Player player2 = new(485, "Juan", 3, 5);
            Player player3 = new(213, "Rafael", 7, 3);
            Player player4 = new(789, "Anibal", 5, 3);
            Player player5 = new(789, "Esteban", 8, 7);

            if (team + player1)
                Console.WriteLine(player1.ShowDataPlayer());

            if (team + player2)
                Console.WriteLine(player2.ShowDataPlayer());

            if (team + player3)
                Console.WriteLine(player3.ShowDataPlayer());
            else
                Console.WriteLine("NO SE AGREGO " + player3.ShowDataPlayer());

            if (team + player4)
                Console.WriteLine(player4.ShowDataPlayer());

            else
                Console.WriteLine("NO SE AGREGO " + player4.ShowDataPlayer());
            if (team + player5)
                Console.WriteLine(player5.ShowDataPlayer());

            else
                Console.WriteLine("NO SE AGREGO " + player5.ShowDataPlayer());
*/

            FootballCoach coach1 = new("Juan", new System.DateTime(1990, 10, 10));
            FootballCoach coach2 = new("Ramon", new System.DateTime(1990, 10, 10));
            FootballCoach coach3 = new("Juan", new System.DateTime(1990, 10, 10));

            if (coach1 == coach2)
            {
                Console.WriteLine($"SON IGUALES: {coach1.ShowData()} {coach2.ShowData()}");
            }          
            else
            {
                Console.WriteLine($"NO SON IGUALES: {coach1.ShowData()} {coach2.ShowData()}");
            }

            if (coach1 == coach3)
            {
                Console.WriteLine($"SON IGUALES: {coach1.ShowData()} {coach3.ShowData()}");
            }
            else
            {
                Console.WriteLine($"NO SON IGUALES: {coach1.ShowData()} {coach3.ShowData()}");
            }

            if (coach2 == coach3)
            {
                Console.WriteLine($"SON IGUALES: {coach2.ShowData()}   {coach3.ShowData()}");
            }
            else
            {
                Console.WriteLine($"NO SON IGUALES: {coach2.ShowData()}   {coach3.ShowData()}");
            }
            Console.ReadKey();
        }
    }
}
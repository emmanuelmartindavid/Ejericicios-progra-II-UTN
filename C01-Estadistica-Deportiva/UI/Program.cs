/*
 Clase Jugador
Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles.
MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
Dos jugadores serán iguales si tienen el mismo DNI.
Clase Equipo
La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
La sobrecarga del operador + agregará jugadores a la lista siempre y cuando no exista aún 
en el equipo y la cantidad de jugadores no supere el límite establecido por el atributo cantidadDeJugadores.
Crear un proyecto de consola y generar las invocaciones necesarias en el método Main para probar el código.*/
using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Team team = new(3, "PATRONATO");
            Player player1 = new(213, "Ismael", 5, 20);
            Player player2 = new(485, "Juan", 3, 5);
            Player player3 = new(213, "Rafael", 7, 3);
            Player player4 = new(789, "Anibal", 5, 3);
            Player player5 = new(789, "Esteban", 8, 7);
           
           if (team+ player1)
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




        }
    }
}
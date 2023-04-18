using System.Text;

namespace Logic
{
    public class Player : Person
    {
        private int _gamesPlayed;
        private int _totalGoals;

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
        }

        public float AverageGoals
        {
            get { return (float)TotalGoals / GamesPlayed; }
        }

        public int TotalGoals
        {
            get { return _totalGoals; }
        }

        public Player(int dni, string name, int totalGoals, int gamesPlayed) : base(dni, name)
        {
            _gamesPlayed = gamesPlayed;
            _totalGoals = totalGoals;
        }


        public string ShowDataPlayer()
        {
            StringBuilder sb = new();
            
            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"partidos jugador: {GamesPlayed}");
            sb.AppendLine($"total goles: {TotalGoals}");
            sb.AppendLine($"Promedio goles: {AverageGoals:0.##}");

            return sb.ToString();
        }

        public static bool operator ==(Player player1, Player player2)
        {
            return player1.Dni == player2.Dni;
        }


        public static bool operator !=(Player player1, Player player2)
        {
            return !(player1 == player2);
        }


    }
}
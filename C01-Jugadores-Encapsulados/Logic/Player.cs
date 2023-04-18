using System.Text;

namespace Logic
{
    public class Player
    {
        private int _dni;
        private string _name;
        private int _gamesPlayed;
        private int _totalGoals;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

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

        private Player()
        {
            Dni = 0;
            Name = "";
            _gamesPlayed = 0;
            _totalGoals = 0;
        }

        public Player(int dni, string name) : this()
        {
            Dni = dni;
            Name = name;

        }

        public Player(int dni, string name, int totalGoals, int gamesPlayed) :
            this(dni, name)
        {
            Dni = dni;
            Name = name;
            _gamesPlayed = gamesPlayed;
            _totalGoals = totalGoals;
        }
        public string ShowDataPlayer()
        {
            StringBuilder sb = new StringBuilder();
            Player player = new();

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
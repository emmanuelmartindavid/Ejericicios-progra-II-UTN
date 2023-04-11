using System.Text;

namespace Logic
{
    public class Player
    {
        private int _dni;
        private string _name;
        private int _gamesPlayed;
        private float _averageGoals;
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
            set { _gamesPlayed = value; }
        }

        public float AverageGoals
        {
            get { return _averageGoals; }
            set { _averageGoals = value; }
        }

        public int TotalGoals
        {
            get { return _totalGoals; }
            set { _totalGoals = value; }
        }

        private Player()
        {
            Dni = 0;
            Name = "";
            GamesPlayed = 0;
            AverageGoals = 0;
            TotalGoals = 0;
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
            GamesPlayed = gamesPlayed;
            TotalGoals = totalGoals;
        }

        public float GetAverageGoals()
        {
            AverageGoals = (float)TotalGoals / GamesPlayed;
            return AverageGoals;
        }

        public string ShowDataPlayer()
        {
            StringBuilder sb = new StringBuilder();
            Player player = new ();

            sb.AppendLine($"Nombre: {Name}" );
            sb.AppendLine($"Dni: {Dni}");
            sb.AppendLine($"partidos jugador: {GamesPlayed}" );
            sb.AppendLine($"total goles: {TotalGoals}" );
            sb.AppendLine($"Promedio goles: {GetAverageGoals():0.##}");

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
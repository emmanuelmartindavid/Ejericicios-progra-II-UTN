using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Team
    {
        private short _playerAmount;
        private string _teamName;
        private List<Player> _players;
        public short PlayerAmount
        {
            get { return _playerAmount; }

        }
        public string TeamName
        {
            get { return _teamName; }
            private set { _teamName = value; }
        }

        public List<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        private Team()
        {
            Players = new List<Player>();
        }

        public Team(short playerAmount, string teamName) : this()
        {
            TeamName = teamName;
            _playerAmount = playerAmount;
        }

        public static bool operator ==(Team team, Player player)
        {
            foreach (Player item in team.Players)
            {
                if (item == player)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool operator !=(Team team, Player player)
        {
            return !(team == player);

        }

        public static bool operator +(Team team, Player player)
        {
            if (team.Players.Count < team.PlayerAmount && team != player)
            {
                team.Players.Add(player);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

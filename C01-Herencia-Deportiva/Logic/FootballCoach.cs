using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FootballCoach : Person
    {
        private DateTime _birthDate;

        private FootballCoach(string name) : base(name)
        {
            Name = name;
        }

        public FootballCoach(string name, DateTime birthDate) : base(name)
        {
            _birthDate = birthDate;  
        }

        public static bool operator ==(FootballCoach left, FootballCoach right)
        {
            return (left.Name == right.Name && left._birthDate == right._birthDate);
        }
        public static bool operator !=(FootballCoach left, FootballCoach right)
        {
            return !(left == right);
        }

        public string ShowData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Nombre DT: {Name}");
            sb.AppendLine($"Fecha de nacimiento: {_birthDate}");
            return sb.ToString();
        }
    }
}

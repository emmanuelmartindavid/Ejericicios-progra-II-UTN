using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Person
    {
        private long _dni;
        private string _name;

        public long Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(long dni, string name): this(name)
        {
            Dni = dni;
        }

        public string ShowData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"DNI: {Dni}");
            sb.AppendLine($"Nombre: {Name}");
            return sb.ToString();
        }   
    }
}

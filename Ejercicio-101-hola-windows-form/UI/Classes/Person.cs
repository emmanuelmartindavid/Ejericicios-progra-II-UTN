using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Classes
{
    public class Person
    {
        private string _name;
        private int _file;

        public string FirstName
        {

            get => _name;
            private set => _name = value;
        }

        public int File
        {
            get => _file;
            private set => _file = value;
        }

        public Person(string name, int file )
        {
            FirstName = name;
            File = file;

        }

        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine( $"{FirstName} {File}");       
            return sb.ToString();
        }










    }
}

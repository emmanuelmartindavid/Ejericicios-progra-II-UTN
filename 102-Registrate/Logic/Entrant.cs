using System.Text;

namespace Logic
{
    public class Entrant
    {
        private string[] _courses;
        private string _adress;
        private int _age;
        private string _name;
        private string _gender;
        private string _country;




        public string[] Courses
        {
            get { return _courses; }
            private set { _courses = value; }
        }

        public string Adress
        {
            get { return _adress; }
            private set { _adress = value; }
        }

        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }

        public string Name
        {
            get { return _name; }
            private set { _name = value; }

        }

        public string Gender
        {
            get { return _gender; }
            private set { _gender = value; }

        }

        public string Country
        {
            get { return _country; }
            private set { _country = value; }

        }
        public Entrant(string name, string adress, string gender, string country, string[] courses, int age)
        {
            Name = name;
            Adress = adress;
            Gender = gender;
            Country = country;
            Courses = courses;
            Age = age;
        }

        public string ShowDataEntrant()
        {
            StringBuilder sb= new StringBuilder();
          
          
            sb.AppendLine($"Nombre: {Name}");
            sb.AppendLine($"Direccion: {Adress}");
            sb.AppendLine($"Edad: {Age}");
            sb.AppendLine($"Genero: {Gender}");
            sb.AppendLine($"Pais: {Country}");
            sb.AppendLine($"Curso/s:");
            foreach (var item in Courses)
            {
                sb.AppendLine($"{item}");

            }  
           return sb.ToString();
        }


    }
}
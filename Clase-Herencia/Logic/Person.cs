namespace Logic
{
    //CON ABSTRACT NO SE PUEDE INSTANCIAR LA CLASE
    abstract public class Person
    {
        private string _name;
        private string _surName;
        private int _dni;

        public string CompleteName
        {
            get => $"{_name} {_surName}";
        }
        public string Name
        {
            // get => _name;
            set => _name = value;
        }

        public string SurName
        {
            // get => _surName;
            set => _surName = value;
        }

        public int Dni
        {
            get => _dni;
            private set => _dni = Validator.ValidateDniOrThrow(value);
        }

        public Person(string name, string surName, int dni) : this(dni)
        {
            Name = name;
            SurName = surName;
        }

        public Person(int dni)
        {
            Dni = dni;

        }

        public override string ToString()
        {
            return $"Nombre completo: {CompleteName}, Dni: {_dni}";
        }

        //VIRTUAL PERMITE SOBREESCRIBIR EL METODO EN UNA CLASE HIJA
        /*  public virtual string SayHi()
          {
              return $"Hola, soy {CompleteName}";
          }*/

        //OBLIGA A SOBREESCRIBIR EL METODO EN LAS CLASES HIJAS
        public abstract string SayHi();
      
    }
}
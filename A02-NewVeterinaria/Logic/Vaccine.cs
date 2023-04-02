namespace Logic
{
    public class Vaccine
    {
        //vacuna 
        //De las vacunas sólo interesa conocer el nombre.
        //The vaccine list needs to know the name.
        public string Name { get; set; }
        public Vaccine(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Vacuna: {Name}";
        }

    }
}
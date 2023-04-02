using System.Text;

namespace Logic
{
    public class Pet
    {
        //pet list.
        //De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación.
        //The pet list needs to know the species, name, birth date and vaccination history.
        public string Species { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Vaccine> Vaccines { get; set; }
        public Pet(string species, string name, DateTime birthDate)
        {
            Species = species;
            Name = name;
            BirthDate = birthDate;
            Vaccines = new List<Vaccine>();
        }
        public override string ToString()
        {
            return $"Pet: {Species} - {Name} - {BirthDate}";
        }


        //method whit a list of pet vaccines
        private void AddVaccine()
        {
            string name = Input.ValidateString("Ingrese el nombre de la vacuna: ", 4, 10);
            Vaccine vaccine = new Vaccine(name);
            Vaccines.Add(vaccine);
        }

        //Method for the client to ask and add pets. It uses the method AddPet(Pet pet) to add the pet to the pet list.
        public static Pet AddPet()
        {
            string species = Input.ValidateString("Ingrese la especie de la mascota: ", 4, 10);
            string name = Input.ValidateString("Ingrese el nombre de la mascota: ", 4, 10);
            DateTime birthDate = Input.ValidateDate("Ingrese la fecha de nacimiento de la mascota: ");
            Pet pet = new Pet(species, name, birthDate);
            //add the vaccine ask
            Console.WriteLine("Desea agregar una vacuna? (s/n)");
            string answer = Console.ReadLine();
            if (answer == "s")
            {
                pet.AddVaccine();
            }

            return pet;
        }

        //Method to return a string with the pet information and the vaccine list, using StringBuilder.
        public string GetPetInfo()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Pet: {Species} - {Name} - {BirthDate}");
            sb.AppendLine("Vaccines:");
            foreach (Vaccine vaccine in Vaccines)
            {
                sb.AppendLine(vaccine.ToString());
            }
            return sb.ToString();
        }

    }
}
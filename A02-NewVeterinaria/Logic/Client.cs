using System;
using System.Text;

namespace Logic
{
    public class Client
    {
        //clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.
        //client adress, name, surname, phone number. A client can have one or more pets.
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; }
        public Client(string adress, string name, string surname, string phoneNumber)
        {
            Adress = adress;
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Pets = new List<Pet>();
        }
        public override string ToString()
        {
            return $"Client: {Name} {Surname} - {PhoneNumber} - {Adress}";
        }

        //Method to add pet to list pet
        public void AddPet(Pet pet)
        {
            Pets.Add(pet);
        }

        //Method to ask client data. It uses class Pet methods to add the pet to the pet list.
        public static Client AddClient()
        {

            string name = Input.ValidateString("Ingrese el nombre del cliente: ", 4, 10);
            string surname = Input.ValidateString("Ingrese el apellido del cliente: ", 4, 10);
            string adress = Input.ValidateAdress("Ingrese el domicilio del cliente: ");
            string phoneNumber = Input.ValidatePhoneNumber("Ingrese el telefono del cliente: ");
            Client client = new(adress, name, surname, phoneNumber);
            //add the pet ask
            Console.WriteLine("Desea agregar una mascota? (s/n)");
            string answer = Console.ReadLine();
            if (answer == "s")
            {
                Pet pet = Pet.AddPet();

                client.AddPet(pet);
            }
            return client;
        }


        //Method to return a string with the client information and the vaccine list, using StringBuilder.  
        public string GetClientInfo()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Cliente: {Name} {Surname} - {PhoneNumber} - {Adress}");
            sb.AppendLine("Macota/s:");
            foreach (Pet pet in Pets)
            {
                sb.AppendLine(pet.GetPetInfo());
            }
            return sb.ToString();
        }


    }
}
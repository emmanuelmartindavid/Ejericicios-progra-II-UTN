using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.*/
namespace Ejercicio18
{
    internal class Person
    {
        private string name;
        private DateTime birthDate;
        private string dni;

        public Person(string name, DateTime date, string dni)
        {
            this.name = name;
            this.birthDate = date;
            this.dni = dni;
            CalculateAge(date);
            ValidateAgeMajority(date);

        }

        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }

        public void SetBirthDate(DateTime birthDate) { this.birthDate = birthDate; }
        public DateTime GetBirthDate() { return this.birthDate; }

        public void SetDni(string dni) { this.dni = dni; }
        public string GetDni() { return this.dni; }

        private static int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
            {
                age--;
            }
            return age;
        }

        private static string ValidateAgeMajority(DateTime birthDate)
        {
            int age = Person.CalculateAge(birthDate);

            if (age > 17)
            {
                return "Mayor de edad";
            }
            return "Menor de edad";
        }

        public string ShowDataPerson()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.name} con dni: {this.dni} tiene {CalculateAge(this.birthDate)} anios de edad, siendo {ValidateAgeMajority(this.birthDate)}");
            
            return sb.ToString();
        }
    }
}

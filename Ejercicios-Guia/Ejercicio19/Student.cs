using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
/*La clase Estudiante:

Tendrá un constructor estático que inicializará el atributo estático random.
Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.

El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.

El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.

El método privado CalcularPromedio retornará el promedio de las dos notas.

El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 
incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.

El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
Nombre, apellido y legajo.
Nota del primer y segundo parcial.
Promedio.
Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
Mostrar los datos de todos los alumnos.
IMPORTANTE
Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random.*/
namespace Ejercicio19
{
    internal class Student
    {
        private readonly string name;
        private readonly string lastName;
        private readonly string file;
        private int firstMidtermGrade;
        private int secondMidtermGrade;
        private readonly static Random rand;

        static Student()
        {
            rand = new Random();
        }

        public Student(string name, string lastName, string file)
        {
            this.name = name;
            this.lastName = lastName;
            this.file = file;

        }

        public void SetFirstGrade(int firstGrade)
        {
            this.firstMidtermGrade = firstGrade;
        }
        public void SetSecondGrade(int secondGrade)
        {
            this.secondMidtermGrade = secondGrade;
        }

        private static decimal CalculateAverage(int firstGrade, int secondGrade)
        {
          return (decimal)(firstGrade + secondGrade) / 2;
        }

        private decimal CalculateFinalGrade()
        {
            decimal finaleGrade = -1;

            if (this.firstMidtermGrade >= 4 && this.secondMidtermGrade >= 4)
            {
                finaleGrade = Student.rand.Next(6, 10);
                return finaleGrade + CalculateAverage(this.firstMidtermGrade, this.secondMidtermGrade);
            }
            return finaleGrade;
        }

        public string ShowStudentData()
        {
            StringBuilder sb = new ();
            decimal finalGrade = CalculateFinalGrade();

            sb.AppendLine($"Alumno: {this.name} {this.lastName}. Legajo: {this.file}");
            sb.AppendLine($"Nota primer parcial: {this.firstMidtermGrade}");
            sb.AppendLine($"Nota segundo parcial: {this.secondMidtermGrade}");
            sb.AppendLine($"Promedio de examenes: {CalculateAverage(firstMidtermGrade, secondMidtermGrade):N2}");
            if (finalGrade != -1)
            {
                sb.AppendLine($"Nota final de materia: {finalGrade:N2}");
            }
            else
            {
                sb.AppendLine("Alumno presenta materia desaprobada. A codear mas, alumne.");
            }
            return sb.ToString();
        }



    }
}

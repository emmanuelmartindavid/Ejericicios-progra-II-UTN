using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Student : Person
    {
        private int _fileNumber;

        public int FileNumber
        {
            get => _fileNumber;
            set => _fileNumber = Validator.ValidateFileNumberOrThrow(value);

        }

        public Student(string name, string surName, int dni, int fileNumber) : base(name, surName, dni)
        {
            FileNumber = fileNumber;
        }

        public Student(int dni, int fileNumber) : base(dni)
        {
            FileNumber = fileNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Legajo: {FileNumber}";
        }

        /*        public override string SayHi()
                {
                    return $"{base.SayHi()}, OVERRIDE SayHi con VIRTUAL y mi legajo es :{FileNumber}";
                }
        */
        public override string SayHi()
        {
            return $"Hola, soy: {CompleteName}, OVERRIDE SayHi con ABSTRACT y mi legajo es :{FileNumber}";
        }

        /*public string SayHi()
         {
             return $"Hola soy {CompleteName} y mi legajo es {FileNumber}";
         }*/

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Validator
    {
        static bool TrueValidateDni(int dni)
        {
            //TODO: Implementar
            return true;
        }
        public static int ValidateDniOrThrow(int dni)
        {
            if (dni < 0)
            {
                throw new ArgumentException("El DNI no es valido");
            }
            return dni;

        }

        public static int ValidateFileNumberOrThrow(int fileNumber)
        {
            if (fileNumber < 100000)
            {
                throw new ArgumentException("El LEGAJO no es valido");
            }
            return fileNumber;

        }
    }
}

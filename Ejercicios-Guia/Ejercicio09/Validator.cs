using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

IMPORTANTE
Utilizar variables escalares, NO utilizar vectores/arrays.
 */
namespace Ejercicio09
{
    internal static class Validator
    {      
        public static bool ValidateRange(int value, int minimus, int maximus)
        {
            return value >= minimus && value <= maximus;
        }
    }
}

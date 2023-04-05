/*Crear dos constructores:

Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:

En el caso de Sumar(long, long) sumará los valores numéricos
En el de Sumar(string, string) concatenará las cadenas de texto.
Crear un proyecto de consola y agregar un objeto del tipo Sumador en el método Main y probar el código.

Seguido:

Generar una conversión explícita que retorne cantidadSumas.

Sobrecargar el operador + (suma) con dos operadores de tipo Sumador. 
El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.

Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador. 
Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el método Main y probar el código.*/
using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder sum = new (2);
            Adder sum2 = new (2);

            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum2.Add(100, 687)} Sumador {sum2.CountSum()}");
            Console.WriteLine($"suma de objetos {sum + sum2}");
            Console.WriteLine($"Suma de long : {sum.Add("Hola ", "Mundo!")} Sumador {sum.CountSum()}");
            if (sum | sum2)
            {
                Console.WriteLine("Son iguales");
            }
            Console.WriteLine($"suma de objetos {sum + sum2}");
        }
    }
}
/*
 Crear una aplicación de consola que cargue en una Lista, 
Pila y Cola 20 números enteros (positivos y negativos) 
distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar la colección tal como fue cargada.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.
*/
using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Lista.ShowListData());
            Console.WriteLine("[=======================================================]");
            Console.WriteLine(Pila.ShowStackData());
            Console.WriteLine("[=======================================================]");
            Console.WriteLine(Cola.ShowQueueData());





        }
    }
}
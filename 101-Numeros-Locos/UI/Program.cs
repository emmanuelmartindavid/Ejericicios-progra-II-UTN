/*Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
distintos de cero de forma aleatoria utilizando la clase Random.

Mostrar el vector tal como fue ingresado.
Luego mostrar los positivos ordenados en forma decreciente.
Por último, mostrar los negativos ordenados en forma creciente.
 */
namespace UI
{
    internal class Program
    {
        //"Hola mundo"";
        //
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int number = random.Next(-100, 100);
                if (number != 0)
                {
                    numbers.Add(random.Next(-100, 100));
                }

            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


       

            //ORDENA DE FORMA DECRECIENTE
            numbers.Sort((number1, number2) =>
            {
                return number2.CompareTo(number1);
            });

            // numbers.Sort();
            
           
            Console.WriteLine("<======ORDEN DECRECIENTE====>");
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    Console.WriteLine(number);
                }

            }


            //ORDENA DE FORMA CRECIENTE
            numbers.Sort((number1, number2) =>
            {
                return number1.CompareTo(number2);
            });
            Console.WriteLine("<======ORDEN CRECIENTE====>");
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    Console.WriteLine(number);
                }

            }





        }
    }
}
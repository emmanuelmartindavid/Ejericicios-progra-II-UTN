using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book[1] = "Hola";
            book[2] = "Mundo";
            book[3] = "Cruel";


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(book[i]);
            }
        
        }
    }
}
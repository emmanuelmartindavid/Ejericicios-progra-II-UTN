using Logica;
namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (Sistema.ValidateUser("Emma", "1234"))
            {
                Console.WriteLine("Logeado");
            }
            else
            {
                Console.WriteLine("Toca de aca");
            }

        }
    }
}
using Logic;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new(1, "Lautaro");
            Client c2 = new(2, "Mauricio");
            Client c3 = new(3, "Esteban");
            Business n1 = new("Kiosco-24");

            if (n1 + c1)
            {
                Console.WriteLine("Se agrego c1 a la cola");
            }

            if (!(n1 + c1))
            {
                Console.WriteLine("Cliente c1 ya esta en la cola");
            }

            if (n1 + c2)
            {
                Console.WriteLine("Se agrego c2 a la cola");
            }

            if (n1 + c3)
            {
                Console.WriteLine("Se agrego c3 a la cola");
            }

            Console.WriteLine("Clientes pendientes: {0}", n1.PendientClients);

            while (~n1)
            {
                Console.WriteLine("Clientes pendientes: {0}", n1.PendientClients);
            }
        }
    }
}
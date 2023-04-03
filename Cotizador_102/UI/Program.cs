using Bills;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro e = new (1, 0.92f);
            Dolar d = new (1);
            Peso p = new (1, 210.35f);
      
            Euro aux_e = e + d;
            Console.WriteLine($"Euro + Dólar: {aux_e.GetAmount():#.000}");
            aux_e = e + p;
            Console.WriteLine($"Euro + Pesos: {aux_e.GetAmount():#.000}");
            Console.WriteLine("----------------------------------------------");


            Dolar aux_d = d + e;
            Console.WriteLine($"Dólar + Euro: {aux_d.GetAmount():#.000}");
            aux_d = d + p;
            Console.WriteLine($"Dólar + Pesos: {aux_d.GetAmount():#.000}");
            Console.WriteLine("----------------------------------------------");


            Peso aux_p = p + e;
            Console.WriteLine($"Pesos + Euro: {aux_p.GetAmount():#.000}");
            aux_p = p + d;
            Console.WriteLine($"Pesos + Dólar: {aux_p.GetAmount():#.000}");

            //test bool operators
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Euro == Dolar: {e == d}");
            Console.WriteLine($"Euro == Peso: {e == p}");
            Console.WriteLine($"Dolar == Euro: {d == e}");
            Console.WriteLine($"Dolar == Peso: {d == p}");
            Console.WriteLine($"Peso == Euro: {p == e}");
            Console.WriteLine($"Peso == Dolar: {p == d}");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"Euro != Dolar: {e != d}");
            Console.WriteLine($"Euro != Peso: {e != p}");
            Console.WriteLine($"Dolar != Euro: {d != e}");
            Console.WriteLine($"Dolar != Peso: {d != p}");
            Console.WriteLine($"Peso != Euro: {p != e}");
            Console.WriteLine($"Peso != Dolar: {p != d}");
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
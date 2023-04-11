using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Input
    {

        public static void ShowProducts(Dictionary<int, Product> expendingMachine)
        {
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            foreach (var item in expendingMachine)
            {
                Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
            }


        }

        public static Dictionary<int, Product> RemoveProduct(Dictionary<int, Product> expendingMachine, int code)
        {
            expendingMachine.Remove(code);
            return expendingMachine;
        }

        public static void ChooseProduct(Dictionary<int, Product> expendingMachine)
        {
            ShowProducts(expendingMachine);
            while (true)
            {

                Console.WriteLine("Ingrese el codigo del producto que desea");
                Console.WriteLine("Ingrese S para salir");
                if (int.TryParse(Console.ReadLine(), out int code))
                {
                    if (expendingMachine.ContainsKey(code))
                    {
                        Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+");
                        Console.WriteLine($"ELIGIO: {expendingMachine[code]}");
                        expendingMachine = RemoveProduct(expendingMachine, code);
                        ShowProducts(expendingMachine);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("El codigo ingresado no es valido");
                    }
                }
                else
                {
                    Console.WriteLine("El codigo ingresado no es valido");
                }

                if (Console.ReadLine().ToUpper() == "S")
                {
                    break;
                }

            }


        }

    }
}

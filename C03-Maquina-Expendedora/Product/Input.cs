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

        public static string ChooseProduct(Dictionary<int, Product> expendingMachine)
        {
            StringBuilder sb = new();
            ShowProducts(expendingMachine);

            while (true)
            {
                sb.AppendLine("Ingrese el codigo del producto que desea");
                sb.AppendLine("Ingrese S para salir");

                if (int.TryParse(Console.ReadLine(), out int code))
                {
                    if (expendingMachine.ContainsKey(code))
                    {
                        sb.AppendLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+");
                        sb.AppendLine($"ELIGIO: {expendingMachine[code]}");
                        expendingMachine = RemoveProduct(expendingMachine, code);
                        ShowProducts(expendingMachine);
                        continue;
                    }
                    else
                    {
                        sb.AppendLine("El codigo ingresado no es valido");
                    }
                }
                else
                {
                    sb.AppendLine("El codigo ingresado no es valido");
                }

                if (Console.ReadLine().ToUpper() == "S")
                {
                    break;
                }

            }
            return sb.ToString();

        }

    }
}

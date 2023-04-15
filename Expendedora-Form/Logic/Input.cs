using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Input
    {
        public static string ShowProduct(Dictionary<int, Stack<Product>> expendingMachine, int code)
        {
            StringBuilder sb = new();

            if (expendingMachine.TryGetValue(code, out Stack<Product> resorte))
            {
                if (resorte.Count == 0)
                {
                    sb.AppendLine("No hay mas productos");
                }
                else
                {
                    sb.AppendLine($"ELIGIO: {resorte.Peek()}");
                }
            }
            else
            {
                sb.AppendLine("El codigo ingresado no es valido");
            }
            return sb.ToString();
        }

        public static void RemoveProduct(Dictionary<int, Stack<Product>> expendingMachine, int code)
        {
            if (expendingMachine.TryGetValue(code, out Stack<Product> resorte))
            {
                if (resorte.Count == 0)
                {
                    expendingMachine.Remove(code);
                }
                else
                {
                    resorte.Pop();
                    expendingMachine[code] = resorte;
                }
            }     
        }

    }
}

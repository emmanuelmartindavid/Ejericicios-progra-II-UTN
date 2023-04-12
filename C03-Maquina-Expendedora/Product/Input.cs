using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class Input
    {

     /*   public static void ShowProducts(Dictionary<int, Stack<Product>> expendingMachine)
        {
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            foreach (var item in expendingMachine)
            {
                Console.WriteLine($"Codigo: {item.Key} - Producto: {item.Value}");
            }
        }*/

        public static void ShowProducts(Dictionary<int, Stack<Product>> expendingMachine)
        {
            Console.WriteLine("PRODUCTOS DISPONIBLES");
            foreach (var item in expendingMachine)
            {
                var code = item.Key;
                var products = item.Value;
                Console.WriteLine($"Código: {code}");
                foreach (var product in products)
                {
                    Console.WriteLine($"\t- {product}");
                }
            }
        }
        public static void ShowOutPuts(Dictionary<int, Stack<Product>> expendingMachine, int code)
        {


            Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+");
            Console.WriteLine($"ELIGIO: {expendingMachine[code]}");
            Console.WriteLine("*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+");


        }

        public static void ShowOutPuts(bool state)
        {
            if (state)
            {
                Console.WriteLine("<=======================================>");
                Console.WriteLine("Ingrese el codigo del producto que desea");
                Console.WriteLine("Ingrese S para salir");
                Console.WriteLine("<=======================================>");
            }
            else
            {
                Console.WriteLine("El codigo ingresado no es valido");
            }

        }

        /* public static Dictionary<int, Stack<Product>> RemoveProduct(Dictionary<int, Stack<Product>> expendingMachine, int code)
         {
             if (expendingMachine.TryGetValue(code, out Stack<Product> resorte))
             {
                 Console.WriteLine("Desea comprar el producto? Ingrese S: ");
                 if (Console.ReadLine() == "S")
                 {
                     resorte.Pop();
                 }
             }
             *//*expendingMachine.Remove(code);*//*
             return expendingMachine;
         }*/

        public static Dictionary<int, Stack<Product>> RemoveProduct(Dictionary<int, Stack<Product>> expendingMachine, int code)
        {
            if (expendingMachine.TryGetValue(code, out Stack<Product> resorte))
            {
                Console.WriteLine("Desea comprar el producto? Ingrese S: ");
                if (Console.ReadLine() == "S")
                {
                    resorte.Pop();
                }
                if (resorte.Count == 0)
                {
                    expendingMachine.Remove(code);
                }
                else
                {
                    expendingMachine[code] = resorte;
                }
            }
            return expendingMachine;
        }



        public static string ChooseProduct(Dictionary<int, Stack<Product>> expendingMachine)
        {
            StringBuilder sb = new();
            
            ShowProducts(expendingMachine);

            while (true)
            {
                ShowOutPuts(true);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int code) && (expendingMachine.ContainsKey(code)))
                {
                    ShowOutPuts(expendingMachine, code);
                    expendingMachine = RemoveProduct(expendingMachine, code);
                    ShowProducts(expendingMachine);
                    continue;
                }
                else
                {
                    ShowOutPuts(false);
                }

                if (input.ToUpper() == "S")
                {
                    break;
                }

            }
            return sb.ToString();

        }

    }
}

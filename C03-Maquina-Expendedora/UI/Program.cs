/*Crear un proyecto de Consola.

Crear e instanciar un objeto de la clase Dictionary<TKey,TValue> llamado maquinaExpendedora.

Cargar por lo menos 10 elementos en formato clave-valor 
(clave = numero de posición, valor = nombre del producto)

Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:

Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.

Pida al usuario elegir el número del producto que quiere

Al seleccionar número, informar al usuario que recibió ese producto 
y volver a mostrar todos los productos SIN el producto que ya eligió

El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.

BONUS: Refactorizar el programa para que en vez de tener un diccionario <int,string>, 

tengamos un diccionario <int,Producto> (que contenga nombre y precio del producto)
 */
using Logic;
using System.ComponentModel;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new ("Pepsi", 100);
            Product p2 = new ("Fanta", 100);
            Product p3 = new ("Sprite", 100);
            Product p4 = new ("Manaos", 100);
            Product p5 = new ("Pepsi Max", 100);
            Product p6 = new ("Coca Cola Zero", 100);
            Product p7 = new ("Fanta Zero", 100);           
            Product p8 = new ("Sprite Zero", 100);
            Product p9 = new ("Manaos Zero", 100);
            Product p10 = new ("Pepsi Zero", 100);


            Dictionary<int, Product> expendingMachine = new()
            {
                { 1, p1},
                { 2, p2 },
                { 3, p3 }   ,
                { 4, p4 },
                { 5, p5 },
                { 6, p6 },
                { 7, p7 },
                { 8, p8 },
                { 9, p9 },
                { 10, p10 },              
            };


            ChooseProduct(expendingMachine);

        }

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
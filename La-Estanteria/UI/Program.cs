/*Crear un proyecto de tipo biblioteca de clases que contenga la clase Producto.

Diagrama de clase

1-Todos sus atributos son privados.
2-Posee sólo un constructor de instancia.
3-El método GetMarca, retornará el valor correspondiente al atributo marca.
4-También poseerá el atributo codigoDeBarras, el cual se publicará 
sólo a través de la conversión explícita nombrada más adelante.

5-El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
6-Posee las siguientes sobrecargas de operadores:
I-explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
II-== (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
III-== (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, 
false caso contrario.
Generar la clase Estante.*/


using LibraryClass;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Shelf estante = new (3, 1);

            // Creo 4 productos
            Product p1 = new("Pepsi", "PESDS97413", (float)18.5);
            Product p2 = new ("Coca-Cola", "COSDS55752", (float)11.5);
            Product p3 = new ("Manaos", "MASDS51292", (float)20.5);
            Product p4 = new ("Crush", "CRSDS54861", (float)10.75);
          

            // Agrego los productos al estante
            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetBrand(), (string)p1, p1.GetPrice());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetBrand(), (string)p1, p1.GetPrice());
            }

            if (estante + p1)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetBrand(), (string)p1, p1.GetPrice());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetBrand(), (string)p1, p1.GetPrice());
            }

            if (estante + p2)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetBrand(), (string)p2, p2.GetPrice());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetBrand(), (string)p2, p2.GetPrice());
            }

            if (estante + p3)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetBrand(), (string)p3, p3.GetPrice());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetBrand(), (string)p3, p3.GetPrice());
            }

            if (estante + p4)
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetBrand(), (string)p4, p4.GetPrice());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetBrand(), (string)p4, p4.GetPrice());
            }

            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Shelf.ShowShelf(estante));
        }
    }
}
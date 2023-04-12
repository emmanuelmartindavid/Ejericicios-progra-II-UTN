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

            ExpendingMachine expendingMachine = new();

            Console.WriteLine(Input.ChooseProduct(expendingMachine.Products));

        }      
    }
}
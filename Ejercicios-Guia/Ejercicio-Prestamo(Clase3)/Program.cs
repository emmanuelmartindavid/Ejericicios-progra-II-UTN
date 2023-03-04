/*Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.*/
namespace Ejercicio_Prestamo_Clase3_
{
    internal class Program
    {
        static void Main()
        {
            Account account1 = new("Monotributista", 0);
            bool exit = true;
            do
            {
                Console.WriteLine("Ingrese 1 para depositar. \nIngrese 2 para extraer dinero. \nIngrese 3 para salir.");

                if (int.TryParse(Console.ReadLine(), out int optionChosen))
                {
                    switch (optionChosen)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un monto a depositar. Ingrese salir para terminar el programa.");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                account1.DepositMoney(depositAmount);
                            }
                            Console.WriteLine(account1.ShowData());
                            break;
                        case 2:
                            Console.WriteLine("Ingrese un monto a quitar de su cuenta. Ingrese salir para terminar el programa.");
                            if (decimal.TryParse(Console.ReadLine(), out decimal extractAmount))
                            {
                                account1.ExtractMoney(extractAmount);
                            }
                            Console.WriteLine(account1.ShowData());
                            break;
                        case 3:
                            exit = false;
                            break;
                    }
                }
            } while (exit);
        }
    }
}
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
        static void Main(string[] args)
        {
            Account account1 = new Account("Monotributista", 0);
            string option;
            int optionChosen;
            string input;
            decimal amount = 0;
            bool conditionNumber;
            bool exit = true;

            do
            {
                Console.WriteLine("Ingrese 1 para depositar. \nIngrese 2 para extraer dinero. \nIngrese 3 para salir.");
                option = Console.ReadLine();
                int.TryParse(option, out optionChosen);
                switch (optionChosen)
                {
                    case 1:
                        Console.WriteLine("Ingrese un monto a depositar. Ingrese salir para terminar el programa.");
                        input = Console.ReadLine();
                        decimal.TryParse(input, out amount);
                        conditionNumber = ValidateNumber(input, amount);
                        if (conditionNumber)
                        {
                            account1.DepositMoney(amount);
                        }
                        Console.WriteLine(account1.ShowData());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un monto a quitar de su cuenta. Ingrese salir para terminar el programa.");
                        input = Console.ReadLine();
                        decimal.TryParse(input, out amount);
                        conditionNumber = ValidateNumber(input, amount);
                        if (conditionNumber)
                        {
                            account1.ExtractMoney(amount);
                        }
                        Console.WriteLine(account1.ShowData());
                        break;
                    case 3:
                        exit = false;
                        break;
                }
            } while (exit);
        }

        static bool ValidateNumber(string input, decimal number)
        {

            if (decimal.TryParse(input, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
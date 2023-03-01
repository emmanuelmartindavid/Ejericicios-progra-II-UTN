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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Prestamo_Clase3_
{
    internal class Account
    {
        private string owner;
        private decimal amount;

        public Account(string owner, decimal amount)
        {
            this.owner = owner;
            this.amount = amount;

        }

        public string GetOwner()
        {
            return owner;
        }

        public decimal GetAmount()
        {
            return amount;
        }

        public void DepositMoney(decimal amount)
        {
            if(amount>0)
            {
                this.amount += amount;
            }
        }

        public void ExtractMoney(decimal amount)
        {
            decimal actualAmount = GetAmount();           
            this.amount = actualAmount - amount;
        }

        public string ShowData()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos de la cuenta");
            sb.AppendLine($"Razon social {GetOwner()}");
            sb.AppendLine($"Dinero en su cuenta ${GetAmount()}");

            return sb.ToString();
        }

    }
}

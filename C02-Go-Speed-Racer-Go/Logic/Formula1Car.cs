using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Formula1Car : RaceVehicle
    {
      private short _horsePower;

        public short HorsePower
        {
            get => _horsePower;
            set => _horsePower = value;
        }

        public Formula1Car(short carNumber, string scuderia) : base(carNumber, scuderia)
        {
        }

        public Formula1Car(short carNumber, string scuderia, short horsePower) : base(carNumber, scuderia)
        {
            HorsePower = horsePower;
        }

        public static bool operator ==(Formula1Car car1, Formula1Car car2)
        {
            if(car1 == car2)
            {
                return true;
            }
          
            return car1.HorsePower == car2.HorsePower;
        } 

        
        public static bool operator !=(Formula1Car car1, Formula1Car car2)
        {
            return !(car1 == car2);
        }

        public new string ShowCarData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.ToString()}");       
            sb.AppendLine($"Potencia: {HorsePower}");
            return sb.ToString();
        }
    }
   
}

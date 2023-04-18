using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Motorcycle : LandVehicle
    {
        private short _cylinderCapacity;
        public short CylinderCapacity
        {
            get { return _cylinderCapacity; }
        }

        public Motorcycle(short numberOfWheels, Colors color, short cylinderCapacity)
            : base(numberOfWheels, color)
        {
            _cylinderCapacity = cylinderCapacity;
        }

        public override string ToString()
        {
            return string.Format($"MOTO.\n {base.ToString()} Cilindrada: {CylinderCapacity}");
        }
      
    }
}

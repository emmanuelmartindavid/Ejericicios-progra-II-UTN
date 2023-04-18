using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum Colors
    {
        Red,
        White,
        Blue,
        Grey,
        Black,
    }

    public abstract class LandVehicle
    {
        private short _numberOfWheels;
        private short _numberOfDoors;
        private Colors _color;

        public short NumberOfWheels
        {
            get { return _numberOfWheels; }
        }

        public short NumberOfDoors
        {
            get { return _numberOfDoors; }
        }

        public Colors Color
        {
            get { return _color; }
        }

        public LandVehicle(short numberOfWheels, short numberOfDoors, Colors color)
        {
            _numberOfWheels = numberOfWheels;
            _numberOfDoors = numberOfDoors;
            _color = color;
        }

        public LandVehicle(short numberOfWheels, Colors color)
            : this(numberOfWheels, 0, color)
        {
        }

        public override string ToString()
        {
            return string.Format($"Numero de Ruedas: {NumberOfWheels}, Numero de Puertas: {NumberOfDoors}, Color: {Color}, " );
        }
    }
}

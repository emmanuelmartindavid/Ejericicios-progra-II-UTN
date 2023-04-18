using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Truck : LandVehicle
    {
        private short _numberOfGears;
        private int _cargoWeight;

        public short NumberOfGears
        {
            get { return _numberOfGears; }
        }

        public int CargoWeight
        {
            get { return _cargoWeight; }
        }

        public Truck(short numberOfWheels, short numberOfDoors, Colors color, short numberOfGears, int cargoWeight)
            : base(numberOfWheels, numberOfDoors, color)
        {
            _numberOfGears = numberOfGears;
            _cargoWeight = cargoWeight;
        }

        public override string ToString()
        {
            return string.Format($"CAMION.\n {base.ToString()} Numero de marchas: {NumberOfGears}, Peso de carga: {CargoWeight}");
        }


    }
}

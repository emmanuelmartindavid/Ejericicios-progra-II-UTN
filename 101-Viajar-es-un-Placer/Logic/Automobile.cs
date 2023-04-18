namespace Logic
{
    public class Automobile : LandVehicle
    {
        private short _numberOfGears;
        private int _numberOfPassengers;
        public short NumberOfGears
        {
            get { return _numberOfGears; }
        }
        public int NumberOfPassengers
        {
            get { return _numberOfPassengers; }
        }
        public Automobile(short numberOfWheels, short numberOfDoors, Colors color, short numberOfGears, int numberOfPassengers)
            : base(numberOfWheels, numberOfDoors, color)
        {
            _numberOfGears = numberOfGears;
            _numberOfPassengers = numberOfPassengers;
        }

        public override string ToString()
        {
            return string.Format($"AUTO.\n {base.ToString()} Numero de marchas: {NumberOfGears}, Numero de pasajeros: {NumberOfPassengers}");
        }
    }
    

    
}
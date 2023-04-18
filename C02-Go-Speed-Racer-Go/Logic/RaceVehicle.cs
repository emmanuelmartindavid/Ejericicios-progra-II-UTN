using System.Text;

namespace Logic
{
    public abstract class RaceVehicle
    {
        private short _fuelAmount;
        private bool _inRace;
        private string _scuderia;
        private int _vehicleNumber;
        private short _remainingLaps;

        public short FuelAmount
        {
            get => _fuelAmount;
            set => _fuelAmount = value;
        }

        public bool InRace
        {
            get => _inRace;
            set => _inRace = value;
        }
        public string Scuderia
        {
            get => _scuderia;
            set => _scuderia = value;
        }

        public int VehicleNumber
        {
            get => _vehicleNumber;
            set => _vehicleNumber = value;
        }


        public short ReamainingLaps
        {
            get => _remainingLaps;
            set => _remainingLaps = value;
        }

        public RaceVehicle(short vehicleNumber, string scuderia)
        {
            VehicleNumber = vehicleNumber;
            Scuderia = scuderia;
            InRace = false;
        }


        public string ShowCarData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Vehiculo: {_vehicleNumber}");
            sb.AppendLine($"Escuderia: {_scuderia}");
            sb.AppendLine($"Vueltas restantes: {_remainingLaps}");
            return sb.ToString();
        }

        public static bool operator ==(RaceVehicle vehicle1, RaceVehicle vehicle2)
        {
            return (vehicle1._vehicleNumber == vehicle2._vehicleNumber && vehicle1._scuderia == vehicle2._scuderia);
        }

        public static bool operator !=(RaceVehicle vehicle1, RaceVehicle vehicle2)
        {
            return !(vehicle1 == vehicle2);
        }
    }
}
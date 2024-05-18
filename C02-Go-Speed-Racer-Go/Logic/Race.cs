using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum RaceType
    {
        Formula1,
        MotoCrossRace,
    }
    public class Race
    {
        private List<RaceVehicle> _competitors;

        public short CompetitorsAmount { get; set; }

        public short LapsAmount { get; set; }

        public RaceVehicle this[int index] => _competitors[index];

        public RaceType RaceType { get; set; }

        private Race()
        {
            _competitors = new List<RaceVehicle>();
        }

        public Race(short lapsAmount, short competitorsAmount, RaceType raceType) : this()
        {
            CompetitorsAmount = competitorsAmount;
            LapsAmount = lapsAmount;
            RaceType = raceType;
        }

        //[MethodImpl(MethodImplOptions.Synchronized)]
        public static bool operator ==(Race race, RaceVehicle vehicle)
        {
            if (race.RaceType is RaceType.Formula1 && vehicle is Formula1Car)
            {
                return true;
            }
            return race.RaceType is RaceType.MotoCrossRace && vehicle is MotCross;
        }
        public static bool operator !=(Race race, RaceVehicle vehicle)
        {
            return !(race == vehicle);
        }


        public static bool operator +(Race race, RaceVehicle vehicle)
        {
            if (race._competitors.Count < race.LapsAmount && race == vehicle)
            {
                race._competitors.Add(vehicle);
                vehicle.InRace = true;
                vehicle.ReamainingLaps = race.LapsAmount;
                Random random = new();
                vehicle.FuelAmount = (short)random.Next(15, 100);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ShowRaceData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"Carrera de tipo: {RaceType}");
            sb.AppendLine($"Cantidad de competidores: {CompetitorsAmount}");
            sb.AppendLine($"Cantidad de vueltas: {LapsAmount}");
            sb.AppendLine($"Competidores: ");
            foreach (var vehicle in _competitors)
            {
                sb.AppendLine($"{vehicle.ShowCarData()}");
            }

            return sb.ToString();
        }
    }
}

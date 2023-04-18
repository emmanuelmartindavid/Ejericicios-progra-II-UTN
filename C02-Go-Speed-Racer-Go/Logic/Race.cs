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
        MotCrossRace,
    }
    public class Race
    {
        private short _competitorsAmount;
        private short _lapsAmount;
        private List<RaceVehicle> _competitors;
        private RaceType _type;

        public short CompetitorsAmount
        {
            get => _competitorsAmount;
            set => _competitorsAmount = value;
        }

        public short LapsAmount
        {
            get => _lapsAmount;
            set => _lapsAmount = value;
        }

        public RaceVehicle this[int index]
        {
            get
            {
                return _competitors[index];
            }
        }

        public RaceType RaceType
        {
            get => _type;
            set => _type = value;
        }

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

        public static bool operator ==(Race race, RaceVehicle vehicle)
        {

            return race.RaceType == race._competitors.;
        }
        public static bool operator !=(Race race, RaceVehicle vehicle)
        {
            return true;

        }


        /*   public static bool operator +(Race race, RaceVehicle vehicle)
           {
               if (race._competitors.Count < race.LapsAmount && race != vehicle)
               {
                   race._competitors.Add(vehicle);
                   car.InRace = true;
                   car.ReamainingLaps = race.LapsAmount;
                   Random random = new Random();
                   car.FuelAmount = (short)random.Next(15, 100);
                   return true;
               }
               else
               {
                   return false;
               }
           }*/

    }
}

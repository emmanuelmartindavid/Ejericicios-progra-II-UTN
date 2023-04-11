using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/* 
 ==Clase Competencia==
El constructor privado será el único capaz de inicializar la lista de competidores.
La sobrecarga del operador + agregará un competidor si es que aún hay espacio 
(validar con cantidadCompetidores) y el competidor no forma parte de la lista (== entre Competencia y AutoF1).
Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero, 
la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia 
y se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible.*/
namespace Logic
{
    public class Race
    {
        private short _competitorsAmount;
        private short _lapsAmount;
        private List<Car> _competitors;

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


        private Race()
        {
            _competitors = new List<Car>();
        }

        public Race(short lapsAmount, short competitorsAmount) : this()
        {
            LapsAmount = lapsAmount;
            CompetitorsAmount = competitorsAmount;
        }

        public static bool operator ==(Race race, Car car)
        {
            foreach (Car item in race._competitors)
            {
                if (item == car)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static bool operator !=(Race race, Car car)
        {
            return !(race == car);
        }

        public static bool operator +(Race race, Car car)
        {
            if (race._competitors.Count < race.LapsAmount && race != car)
            {
                race._competitors.Add(car);
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
        }

        public string ShowDataRace()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------CARRERA--------");
            sb.AppendLine($"COMPETIDORES: {CompetitorsAmount}");
            foreach (Car car in _competitors)
            {
                sb.AppendLine("----------------------");
                sb.AppendLine(car.ShowCarData());
                sb.AppendLine("----------------------");

            }
            return sb.ToString();
        }
    }
}

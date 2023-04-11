using System;
using System.Collections.Generic;
using System.Linq;
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
    internal class Race
    {
        private short _competitorsAmount;
        private short _lapsAmount;
        private List<Car> _competitors;

        public short CompetitorsAmount
        {
            get => _competitorsAmount;
            set => _competitorsAmount = value;
        }

        private Race()
        {
            _competitors = new List<Car>();
        }

        public Race(short lapsAmount, short competitorsAmount) : this()
        {
            _lapsAmount = lapsAmount;
            _competitorsAmount = competitorsAmount;
        }








        public string ShowDataRace()
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }



    }
}

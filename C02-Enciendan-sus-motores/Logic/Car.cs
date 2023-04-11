/*
 ==Clase AutoF1==
Al generar un auto se cargará el atributo enCompetencia como falso. 
Inicializar cantidadCombustible y vueltasRestantes en 0.
Dos autos serán iguales si los atributos número y escuderia son iguales.
Realizar los métodos getters y setters para cantidadCombustible , enCompetencia y vueltasRestantes.
 */
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Text;

namespace Logic
{
    public class Car
    {
        private short _fuelAmount;
        private bool _inRace;
        private string _scuderia;
        private int _carNumber;
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

        public short ReamainingLeaps
        {
            get => _remainingLaps;
            set => _remainingLaps = value;
        }


        public Car(short carNumber, string scuderia)
        {
            _carNumber = carNumber;
            _scuderia = scuderia;
            InRace = false;
        }



        public string ShowCarData()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("[====================]");
            sb.AppendLine("");
            sb.AppendLine("[====================]");


            return sb.ToString();
        }

        public static bool operator ==(Car car1, Car car2)
        {
            return (car1._carNumber == car2._carNumber && car1._scuderia == car2._scuderia);
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }

    }
}
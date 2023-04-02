using System.Text;

namespace Logic
{
    public class TruckDriver
    {
        public string NameDriver;

        public int[] WorkDays;

        public TruckDriver(string nameDriver, int[] workDays)
        {
            NameDriver = nameDriver;
            WorkDays = workDays;
        }

        public int CalculateTotalKmPerDriver()
        {
            return WorkDays.Sum();
        }

        public int CalculateKilometersPerday(int day)
        {
            return WorkDays[day - 1];
        }

        public static TruckDriver DevolverConductorMayorKmSemana(TruckDriver[] conductores)
        {
            int max = 0;
            TruckDriver conductorMayor = null;


            foreach (TruckDriver item in conductores)
            {
                if (item.CalculateTotalKmPerDriver() > max)
                {
                    max = item.CalculateTotalKmPerDriver();
                    conductorMayor = item;
                }
            }
            return conductorMayor;
        }


        public static TruckDriver DevolverConductorMayorKmPerDia(TruckDriver[] conductores, int dia)
        {
            int max = 0;
            TruckDriver conductorMayor = null;


            foreach (TruckDriver item in conductores)
            {
                int kms = item.CalculateKilometersPerday(dia);
                if (kms > max)
                {
                    max = kms;
                    conductorMayor = item;
                }
            }
            return conductorMayor;
        }

        public static TruckDriver[] CreateTruckDrivers()
        {
            TruckDriver[] conductores = new TruckDriver[3];
            int[] kilometros = new int[7];

            for (int i = 0; i < conductores.Length; i++)
            {
                string nombre = Input.CargarNombre();
                kilometros = Input.CargarKilometros();

                conductores[i] = new TruckDriver(nombre, kilometros);
            }
            return conductores;
        }

        public static string ShowDataDriver(TruckDriver[] conductores)
        {
            StringBuilder sb = new StringBuilder();
            TruckDriver conductorMayor = TruckDriver.DevolverConductorMayorKmSemana(conductores);
            TruckDriver conductorMayor3 = TruckDriver.DevolverConductorMayorKmPerDia(conductores, 3);
            TruckDriver conductorMayor5 = TruckDriver.DevolverConductorMayorKmPerDia(conductores, 5);

            sb.AppendLine($"El conductor que realizó mas kilometrajes fue: {conductorMayor.NameDriver} y la cantidad fue: {conductorMayor.CalculateTotalKmPerDriver()}");
            sb.AppendLine($"El conductor que realizó mas kilometrajes en el tercer fue: {conductorMayor3.NameDriver} y la cantidad fue: {conductorMayor3.CalculateKilometersPerday(3)}");
            sb.AppendLine($"El conductor que realizó mas kilometrajes fue: {conductorMayor5.NameDriver} y la cantidad fue: {conductorMayor5.CalculateKilometersPerday(5)}");

            return sb.ToString();

        }

    }
}
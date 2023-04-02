using System.Text;

namespace Logic
{
    public class TruckDriver
    {
        public string DriverName;

        public int[] WorkDays;

        public TruckDriver(string driverName, int[] workDays)
        {
            DriverName = driverName;
            WorkDays = workDays;
        }

        public int CalculateTotalKmPerDriver()
        {
            return WorkDays.Sum();
        }

        public int CalculateKilometersPerDay(int day)
        {
            return WorkDays[day - 1];
        }

        public static TruckDriver GetMaxTruckDriverPerWeek(TruckDriver[] truckDrivers)
        {
            int max = 0;
            TruckDriver maxtruckDriver = null;


            foreach (TruckDriver item in truckDrivers)
            {
                if (item.CalculateTotalKmPerDriver() > max)
                {
                    max = item.CalculateTotalKmPerDriver();
                    maxtruckDriver = item;
                }
            }
            return maxtruckDriver;
        }


        public static TruckDriver GetMaxTruckDriverPerDay(TruckDriver[] truckDrivers, int dia)
        {
            int max = 0;
            TruckDriver maxtruckDriver = null;


            foreach (TruckDriver item in truckDrivers)
            {
                int kms = item.CalculateKilometersPerDay(dia);
                if (kms > max)
                {
                    max = kms;
                    maxtruckDriver = item;
                }
            }
            return maxtruckDriver;
        }

        public static TruckDriver[] CreateTruckDrivers()
        {
            TruckDriver[] truckDrivers = new TruckDriver[3];
            int[] kilometers = new int[7];

            for (int i = 0; i < truckDrivers.Length; i++)
            {
                string name = Input.CargarNombre();
                kilometers = Input.CargarKilometros();

                truckDrivers[i] = new TruckDriver(name, kilometers);
            }
            return truckDrivers;
        }

        public static string ShowDataDriver(TruckDriver[] truckDrivers)
        {
            StringBuilder sb = new StringBuilder();
            TruckDriver conductorMayor = TruckDriver.GetMaxTruckDriverPerWeek(truckDrivers);
            TruckDriver conductorMayor3 = TruckDriver.GetMaxTruckDriverPerDay(truckDrivers, 3);
            TruckDriver conductorMayor5 = TruckDriver.GetMaxTruckDriverPerDay(truckDrivers, 5);

            sb.AppendLine($"El conductor que realizó mas kilometrajes fue: {conductorMayor.DriverName} y la cantidad fue: {conductorMayor.CalculateTotalKmPerDriver()}");
            sb.AppendLine($"El conductor que realizó mas kilometrajes en el tercer fue: {conductorMayor3.DriverName} y la cantidad fue: {conductorMayor3.CalculateKilometersPerDay(3)}");
            sb.AppendLine($"El conductor que realizó mas kilometrajes fue: {conductorMayor5.DriverName} y la cantidad fue: {conductorMayor5.CalculateKilometersPerDay(5)}");

            return sb.ToString();

        }

    }
}
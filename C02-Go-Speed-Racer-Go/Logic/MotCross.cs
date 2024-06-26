﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MotCross : RaceVehicle
    {
        public short CylinderCapacity { get; set; }

        public MotCross(short vehicleNumber, string scuderia) : base(vehicleNumber, scuderia)
        {
        }

        public MotCross(short vehicleNumber, string scuderia, short cylinderCapacity) : base(vehicleNumber, scuderia)
        {
            CylinderCapacity = cylinderCapacity;
        }

        public static bool operator ==(MotCross mot1, MotCross mot2)
        {        
            return (RaceVehicle)mot1 == mot2 && mot1.CylinderCapacity == mot2.CylinderCapacity;
        }

        public static bool operator !=(MotCross mot1, MotCross mot2)
        {
            return !(mot1 == mot2);
        }

        public new string ShowCarData()
        {
            StringBuilder sb = new();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($"Cilindrada: {CylinderCapacity}");
            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class Xiaomi : SmartphoneBase
    {
        public int BatteryCapacity { get; set; } // Battery capacity in mAh

        public Xiaomi(string model, float displaySize, decimal price, int stock, int batteryCapacity)
            : base(model, "Xiaomi", displaySize, price, stock)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override string DescribeUniqueFeature()
        {
            return $"{Manufacturer} {Model} stands out with its high battery capacity of {BatteryCapacity}mAh, ensuring long-lasting performance.";
        }
    }
}


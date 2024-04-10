using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class OnePlus : SmartphoneBase
    {
        public bool HasWarpCharge { get; set; }

        public OnePlus(string model, float displaySize, decimal price, int stock, bool hasWarpCharge)
            : base(model, "OnePlus", displaySize, price, stock)
        {
            HasWarpCharge = hasWarpCharge;
        }

        public override string DescribeUniqueFeature()
        {
            return HasWarpCharge ? $"{Manufacturer} {Model} supports Warp Charge for fast charging." : base.DescribeUniqueFeature();
        }
    }
}


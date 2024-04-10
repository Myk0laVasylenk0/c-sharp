using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class SamsungGalaxy : SmartphoneBase
    {
        public bool HasSpen { get; set; }

        public SamsungGalaxy(string model, float displaySize, decimal price, int stock, bool hasSpen)
            : base(model, "Samsung", displaySize, price, stock)
        {
            HasSpen = hasSpen;
        }

        public override string DescribeUniqueFeature()
        {
            return HasSpen ? $"{Manufacturer} {Model} comes with an S Pen for enhanced productivity." : base.DescribeUniqueFeature();
        }
    }
}

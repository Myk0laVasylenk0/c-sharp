using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class IPhone : SmartphoneBase
    {
        public bool HasFaceID { get; set; }

        public IPhone(string model, float displaySize, decimal price, int stock, bool hasFaceID)
            : base(model, "Apple", displaySize, price, stock)
        {
            HasFaceID = hasFaceID;
        }

        public override string DescribeUniqueFeature()
        {
            return HasFaceID ? $"{Manufacturer} {Model} supports Face ID for secure authentication." : base.DescribeUniqueFeature();
        }
    }
}

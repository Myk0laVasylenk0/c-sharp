using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class SamsungGalaxy : SmartphoneBase
    {
        // Additional properties unique to SamsungGalaxy can be added here

        public SamsungGalaxy(string model, float displaySize, decimal price, int stock)
            : base(model, "Samsung", displaySize, price, stock)
        {
        }

        // You can override methods from the base class or add new methods specific to SamsungGalaxy
    }
}

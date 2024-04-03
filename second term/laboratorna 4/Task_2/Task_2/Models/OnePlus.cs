using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class OnePlus : SmartphoneBase
    {
        // OnePlus-specific properties or methods can be defined here

        public OnePlus(string model, float displaySize, decimal price, int stock)
            : base(model, "OnePlus", displaySize, price, stock)
        {
        }

        // Potential for overriding methods or introducing new behaviors specific to OnePlus
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class Xiaomi : SmartphoneBase
    {
        // Additional properties or methods unique to Xiaomi smartphones

        public Xiaomi(string model, float displaySize, decimal price, int stock)
            : base(model, "Xiaomi", displaySize, price, stock)
        {
        }

        // Example of overriding a base class method or adding Xiaomi-specific functionality
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class IPhone : SmartphoneBase
    {
        public IPhone(string model, float displaySize, decimal price, int stock)
            : base(model, "Apple", displaySize, price, stock)
        {
        }
    }
}

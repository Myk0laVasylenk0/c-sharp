using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public abstract class Vehicle
    {
        public int Speed { get; set; }

        public Vehicle(int speed)
        {
            Speed = speed;
        }

        public abstract int GetNumberOfWheels();

    }
}

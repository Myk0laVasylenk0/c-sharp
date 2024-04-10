using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5
{
    public abstract class TwoWheeledVehicle : Vehicle
    {
        public TwoWheeledVehicle(int speed) : base(speed) { }

        public override int GetNumberOfWheels() => 2;
    }

}

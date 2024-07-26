using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.vehicle
{
    internal class Motorcycle : IVehicle
    {
        public Motorcycle(double Distance, double Time) : base(Distance,Time)
        {
            name = "Motorcycle";
            if(time <= 0 || Distance <= 0)
            {
                throw new Exception("invalid value");
            }

        }
    }
}

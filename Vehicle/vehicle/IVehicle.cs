using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicle.vehicle
{
    internal class IVehicle
    {
        public IVehicle(double Distance, double Time)
        {
            time = Time;
            distance = Distance;
        }
        public double distance { get; }
        public double time { get; }

        public string name;
        public void Speed()
        {
            Console.WriteLine($"the {name} is moved {distance / time} Km/h");
        }
    }
}

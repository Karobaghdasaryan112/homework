using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle.vehicle
{
    internal class Car : IVehicle
    {
        private readonly double _distance;
        private readonly double _time;
        public Car(double Distance, double Time) : base(Distance,Time)
        {
            name = "Car";
            if (time <= 0 || Distance <= 0)
            {
                throw new Exception("invalid value");
            }
            _distance = Distance;
            _time = Time;
        }
    }
}

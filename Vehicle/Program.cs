using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle.vehicle;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(120.4,2);
            car.Speed();

            Car car2 = new Car(120.4, 2);
            car2.Speed();
            //implicit casting up
            IVehicle vehicle = new Motorcycle(10,20);
            vehicle.Speed();
            //explicit casting up
            if(vehicle is Motorcycle motorcycle)
            {
                motorcycle.Speed();
            }
            Console.ReadLine();
        }
    }
}

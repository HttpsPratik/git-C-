using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
     class Program
    {
        static void Main()
        {
            VehicleFactory CarFactory = new CarFactory();
            Vehicle Car = CarFactory.CreateVehicle();
            Car.Drive();

            VehicleFactory BikeFactory = new BikeFactory();
            Vehicle Bike = BikeFactory.CreateVehicle();
            Bike.Drive();


        }
    }
}

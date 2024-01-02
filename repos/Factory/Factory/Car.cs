using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Car : Vehicle
    {
        public void Drive(){

            Console.WriteLine("Car is driving");
        }
    }
    
    public class Bike : Vehicle 
    {
        public void Drive()
        {
            Console.WriteLine("Bike is riding");
        }
    }
}


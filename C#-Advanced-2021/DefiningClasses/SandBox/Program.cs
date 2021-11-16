using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpecs
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "E60", 2004, 7.2, 70);
            //car.Year = 2004;
            //car.Make = "BMW E60";
            //car.FuelQuantity = 70;
            //car.FuelConsumption = 7.2;
            car.Drive(99.5);
            Console.WriteLine(car.ToString());
            car.Drive(324.4);
            Console.WriteLine(car.ToString());
            car.Drive(489.5);
            Console.WriteLine(car.ToString());
            car.Drive(48.9);
            Console.WriteLine(car.ToString());
            car.Drive(14.1);
            Console.WriteLine(car.ToString());
        }
    }
}

using NeedForSpeed.Interfaces;
using NeedForSpeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Core
{
    public class CarFactory : ICarFactory
    {
        public Car CreateCar(string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            Car car = null;

            if (type == "Performance")
            {
                car = new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            }
            else if (type == "Show")
            {
                car = new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            }

            return car;
        }
    }
}

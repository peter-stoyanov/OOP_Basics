using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public class ShowCar : Car
    {
        private const int HORSE_POWER_INCREASE_COEFF = 150 / 100;
        private const int SUSPENSION_DECREASE_COEFF = 1 - 25 / 100;

        private int _stars;

        public ShowCar(string brand,
            string model,
            int yearOfProduction,
            int horsepower,
            int acceleration,
            int suspension,
            int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
        }

        public int Stars
        {
            get { return this._stars; }
            set { if (value > 0) { this._stars = value; } else { throw new ArgumentException("Stars should be positive integer."); } }
        }

        public override string ToString()
        {
            return base.ToString() + $"\n{this.Stars} *";
        }
    }
}

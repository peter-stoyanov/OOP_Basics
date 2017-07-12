using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public class PerformanceCar : Car   //derived class name includes base class name ?
    {
        private const int HORSE_POWER_INCREASE_COEFF = 150 / 100;
        private const int SUSPENSION_DECREASE_COEFF = 1 - 25 / 100;

        private List<string> _addOns;

        public PerformanceCar(string brand, 
            string model, 
            int yearOfProduction, 
            int horsepower, 
            int acceleration,
            int suspension, 
            int durability) : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
        {
            this._addOns = new List<string>();
        }

        public override int HorsePower { get => base.HorsePower; set => base.HorsePower = value * HORSE_POWER_INCREASE_COEFF ; }

        public override int Suspension { get => base.Suspension; set => base.Suspension = value * SUSPENSION_DECREASE_COEFF; }

        public List<string> AddOns
        {
            get { return this._addOns; }
            set { this._addOns = value; }
        }

        public override string ToString()
        {
            if (this.AddOns.Count > 0)
            {
                return base.ToString() + $"\nAdd-ons: {String.Join(", ", this.AddOns)}";
            }
            else
            {
                return base.ToString() + $"\nAdd-ons: None";
            }
        }
    }
}

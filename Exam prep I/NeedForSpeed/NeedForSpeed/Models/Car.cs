using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public abstract class Car //public abstract ?
    {
        private int _id;
        private string _brand;
        private string _model;
        private int _yearOfProduction;
        private int _horsePower;
        private int _acceleration;
        private int _suspension;
        private int _durability;

        public Car(string brand, 
            string model, 
            int yearOfProduction, 
            int horsepower, 
            int acceleration, 
            int suspension, 
            int durability)
        {
            this.Brand = brand;
            this.Model = model;
            this.YearOfProduction = yearOfProduction;
            this.HorsePower = horsepower;
            this.Acceleration = acceleration;
            this.Suspension = suspension;
            this.Durability = durability;

        }

        public string Brand
        {
            get { return this._brand; }
            set { if (value.Length != 0) { this._brand = value; } else { throw new ArgumentException("Brand can not be empty string"); } } //check ?
        }

        public string Model
        {
            get { return this._model; }
            set { if (value.Length != 0) { this._model = value; } else { throw new ArgumentException("Model can not be empty string"); } }
        }

        public int YearOfProduction
        {
            get { return this._yearOfProduction; }
            set { if (value > 0) { this._yearOfProduction = value; } else { throw new ArgumentException("Year of Production should be positive integer."); } }
        }

        public virtual int HorsePower
        {
            get { return this._horsePower; }
            set { if (value > 0) { this._horsePower = value; } else { throw new ArgumentException("Horse power should be positive integer."); } }
        }

        public int Acceleration
        {
            get { return this._acceleration; }
            set { if (value > 0) { this._acceleration = value; } else { throw new ArgumentException("Acceleration should be positive integer."); } }
        }

        public virtual int Suspension
        {
            get { return this._suspension; }
            set { if (value > 0) { this._suspension = value; } else { throw new ArgumentException("Suspension should be positive integer."); } }
        }

        public int Durability
        {
            get { return this._durability; }
            set { if (value > 0) { this._durability = value; } else { throw new ArgumentException("Durability should be positive integer."); } }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Brand} {this.Model} {this.YearOfProduction}\n");
            sb.Append($"{this.HorsePower} HP, 100 m/h in {this.Acceleration} s\n");
            sb.Append($"{this.Suspension} Suspension force, {this.Durability} Durability\n");

            return sb.ToString();
        }
    }
}

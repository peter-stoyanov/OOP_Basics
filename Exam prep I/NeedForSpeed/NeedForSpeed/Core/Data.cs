using NeedForSpeed.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeedForSpeed.Models;

namespace NeedForSpeed.Core
{
    public class Data : IData
    {
        private Dictionary<int, Car> _cars;
        private Dictionary<int, Race> _races;

        public Data()
        {
            this._cars = new Dictionary<int, Car>();
            this._races = new Dictionary<int, Race>();
        }

        public IEnumerable<Car> Cars => (IEnumerable<Car>)this._cars;
        public IEnumerable<Race> Races => (IEnumerable<Race>)this._races;

        public void AddCar(int id, Car car)
        {
            if (car == null)
            {
                throw new ArgumentException(nameof(car));
            }
            this._cars.Add(id, car);
        }

        public void AddRace(int id, Race race)
        {
            if (race == null)
            {
                throw new ArgumentException(nameof(race));
            }
            this._races.Add(id, race);
        }

    }
}

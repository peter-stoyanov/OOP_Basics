using NeedForSpeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Interfaces
{
    public interface IData
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Race> Races { get; }

        void AddCar(int id, Car car);
        void AddRace(int id, Race race);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Interfaces
{
    public interface ICarManager
    {
        void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability);
        string Check(int id);
        void Open(int id, string type, int length, string route, int prizePool);
        void Participate(int carId, int raceId);
        string Start(int id);
        void Park(int id);
        void Unpark(int id);
        void Tune(int tuneIndex, string addOn);

    }
}

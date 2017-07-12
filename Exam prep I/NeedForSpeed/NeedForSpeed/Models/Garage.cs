using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public class Garage
    {
        private Dictionary<int, Car> _parkedCars;

        public Garage()
        {
            this._parkedCars = new Dictionary<int, Car>();
        }

        public void ModifyCar()
        {
            //TODO
        }
    }
}

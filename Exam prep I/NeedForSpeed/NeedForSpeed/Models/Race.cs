using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public abstract class Race
    {
        private int _length;
        private string _route;
        private int _prizePool;
        
        protected Dictionary<int, Car> _participants;

        public Race(int length, string route, int prizePool)
        {
            this.Length = length;
            this.Route = route;
            this.PrizePool = prizePool;

            //initialize collections
            this._participants = new Dictionary<int, Car>();
        }

        public int Length
        {
            get { return this._length; }
            set { if (value > 0) { this._length = value; } else { throw new ArgumentException("Length should be positive integer."); } } //check ?
        }

        public string Route
        {
            get { return this.Route; }
            set { if (value.Length != 0) { this._route = value; } else { throw new ArgumentException("Route can not be empty string"); } }
        }

        public int PrizePool
        {
            get { return this._prizePool; }
            set { if (value > 0) { this._prizePool = value; } else { throw new ArgumentException("Prize pool should be positive integer."); } } //check ?
        }
    }
}

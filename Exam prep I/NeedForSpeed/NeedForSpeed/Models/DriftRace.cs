using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public class DriftRace : Race
    {
        public DriftRace(int length, string route, int prizePool) : base(length, route, prizePool)
        {
        }
    }
}

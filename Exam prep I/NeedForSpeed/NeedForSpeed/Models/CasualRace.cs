using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Models
{
    public class CasualRace : Race
    {
        public CasualRace(int length, string route, int prizePool) : base(length, route, prizePool)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame
{
    class Player
    {
        protected internal int Score { get; set; }

        protected internal virtual void GiveScore(int points)
        {
            this.Score += points;
        }
    }
}

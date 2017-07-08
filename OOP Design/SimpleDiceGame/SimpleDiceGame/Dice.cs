using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame
{
    class Dice
    {
        private const int MIN_DICE_VALUE = 1;
        private const int MAX_DICE_VALUE = 8;

        private Random rnd;

        public Dice()
        {
            this.rnd = new Random();
        }

        protected internal virtual int Roll()
        {
            return this.rnd.Next(MIN_DICE_VALUE, MAX_DICE_VALUE);
        }
    }
}

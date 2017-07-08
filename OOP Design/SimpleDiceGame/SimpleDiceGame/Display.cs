using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDiceGame
{
    class Display
    {
        protected internal virtual string ListenForCommands()
        {
            return Console.ReadLine();
        }

        protected internal virtual void DisplayMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}

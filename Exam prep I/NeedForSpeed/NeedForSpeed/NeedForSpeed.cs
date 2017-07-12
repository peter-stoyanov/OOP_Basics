using NeedForSpeed.Core;
using NeedForSpeed.IO;
using NeedForSpeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    class NeedForSpeed
    {
        static void Main(string[] args)
        {
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new Data();

            CarManager carManager = new CarManager(reader, writer, data);

            carManager.Start();
        }
    }
}

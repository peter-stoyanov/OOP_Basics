using NeedForSpeed.Interfaces;
using System;
using System.Collections.Generic;

namespace NeedForSpeed.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Output(string message)
        {
            Console.WriteLine(message);
        }
    }
}

using NeedForSpeed.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.IO
{
    public class CommandInterpreter
    {
        private ICarManager _carManager;

        public CommandInterpreter(ICarManager carManager)
        {
            this._carManager = carManager;
        }

        public void InterpretCommand(string input)
        {
            string[] data = input.Split(' ');
            string command = data[0];
            switch (command)
            {
                case "register":
                    int id = int.Parse(data[1]);
                    string type = data[2];
                    string brand = data[3];
                    string model = data[4];
                    int year = int.Parse(data[5]);
                    int horsePower = int.Parse(data[6]);
                    int acceleration = int.Parse(data[7]);
                    int suspension = int.Parse(data[8]);
                    int durability = int.Parse(data[9]);

                    this._carManager.Register(id, type, brand, model, year, horsePower, acceleration, suspension, durability);
                    break;
                case "check":
                    id = int.Parse(data[1]);

                    this._carManager.Check(id);
                    break;
                case "open":
                    id = int.Parse(data[1]);
                    type = data[2];
                    int length = int.Parse(data[3]);
                    string route = data[4];
                    int prizePool = int.Parse(data[5]);

                    this._carManager.Open(id, type, length, route, prizePool);
                    break;
                case "participate":
                    id = int.Parse(data[1]);
                    int raceId = int.Parse(data[2]);

                    this._carManager.Participate(id, raceId);
                    break;
                case "start":
                    raceId = int.Parse(data[1]);

                    this._carManager.Start(raceId);
                    break;
                case "park":
                    id = int.Parse(data[1]);

                    this._carManager.Park(id);
                    break;
                case "unpark":
                    id = int.Parse(data[1]);

                    this._carManager.Unpark(id);
                    break;
                case "tune":
                    int tuneIndex = int.Parse(data[1]);
                    string tuneAddOn = data[2];

                    this._carManager.Tune(tuneIndex, tuneAddOn);
                    break;
                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }
        
        private void DisplayInvalidCommandMessage(string input)
        {
            ConsoleWriter.WriteMessageOnNewLine($"The command '{input}' is invalid");
        }
    }
}
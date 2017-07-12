using NeedForSpeed.Interfaces;
using NeedForSpeed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed.Core
{
    public class CarManager
    {
        private const string END_COMMAND = "Cops Are Here";

        private IInputReader _reader;
        private IOutputWriter _writer;
        private IData _data;
        private ICarFactory _carFactory;
        private Garage garage;

        public CarManager(IInputReader reader, IOutputWriter writer, IData data)
        {
            this._reader = reader;
            this._writer = writer;
            this._data = data;

            this._carFactory = new CarFactory();
            this.garage = new Garage();
        }

        public void Start()
        {
            while (true)
            {
                string input = this._reader.ReadLine();
                this.ExecuteCommands(input);
            }
        }

        private void ExecuteCommands(string input)
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

                    this.Register(id, type, brand, model, year, horsePower, acceleration, suspension, durability);
                    break;
                case "check":
                    id = int.Parse(data[1]);

                    this.Check(id);
                    break;
                case "open":
                    id = int.Parse(data[1]);
                    type = data[2];
                    int length = int.Parse(data[3]);
                    string route = data[4];
                    int prizePool = int.Parse(data[5]);

                    this.Open(id, type, length, route, prizePool);
                    break;
                case "participate":
                    id = int.Parse(data[1]);
                    int raceId = int.Parse(data[2]);

                    this.Participate(id, raceId);
                    break;
                case "start":
                    raceId = int.Parse(data[1]);

                    this.Start(raceId);
                    break;
                case "park":
                    id = int.Parse(data[1]);

                    this.Park(id);
                    break;
                case "unpark":
                    id = int.Parse(data[1]);

                    this.Unpark(id);
                    break;
                case "tune":
                    int tuneIndex = int.Parse(data[1]);
                    string tuneAddOn = data[2];

                    this.Tune(tuneIndex, tuneAddOn);
                    break;
                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }

        private void DisplayInvalidCommandMessage(string input)
        {
            this._writer.Output($"The command '{input}' is invalid");
        }

        public string Check(int id)
        {
            //var currentCar = this._data.Cars[id];
            //return currentCar.ToString();
        }

        public void Open(int id, string type, int length, string route, int prizePool)
        {
            throw new NotImplementedException();
        }

        public void Park(int id)
        {
            throw new NotImplementedException();
        }

        public void Participate(int carId, int raceId)
        {
            throw new NotImplementedException();
        }

        public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            var car = _carFactory.CreateCar(type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
            this._data.AddCar(id, car);
        }

        public string Start(int id)
        {
            throw new NotImplementedException();
        }

        public void Tune(int tuneIndex, string addOn)
        {
            throw new NotImplementedException();
        }

        public void Unpark(int id)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleDiceGame;

namespace SimpleDiceGame
{
    class Game
    {
        private const int WIN_POINTS = 10;
        private const int SUCCESS_DICE_SCORE = 7;

        private Display _display;
        private Player _player;
        private Dice _dice;

        public Game()
        {
            this._display = new Display();
            this._player = new Player();
            this._dice = new Dice();
        }  
      
        public void Start()
        {
            _display.DisplayMessage(GlobalConstants.START_GAME_MESSAGE);

            ExecuteCommand();

        }

        private void ExecuteCommand()
        {
            string command;
            while (true)
            {
                _display.DisplayMessage(GlobalConstants.WAIT_FOR_COMMANDS_MESSAGE);

                command = _display.ListenForCommands();

                switch (command)
                {
                    case "yes":
                        StartAnotherTurn();
                        break;
                    case "exit":
                        _display.DisplayMessage(GlobalConstants.END_GAME_MESSAGE);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private void StartAnotherTurn()
        {
            int result = this._dice.Roll();

            this._display.DisplayMessage($"The dice shows {result} .");

            if (result == SUCCESS_DICE_SCORE)
            {
                this._player.GiveScore(WIN_POINTS);

                this._display.DisplayMessage($"Your new score is {this._player.Score} points.");
            }
            else
            {
                this._display.DisplayMessage($"Your score is as before : {this._player.Score} points.");
            }
        }
    }
}

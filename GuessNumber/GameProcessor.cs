using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    public class GameProcessor
    {
        private readonly Func<string> _inputProvider;
        private readonly Action<string> _outputProvider;
        private SecretNumber _randomNumber;

        public GameProcessor(Func<string> inputProvider, Action<string> outputProvider)
        {
            _inputProvider = inputProvider;
            _outputProvider = outputProvider;
            StartNewGame();
            InitiateNewGameOrClose();
        }

        private void StartNewGame()
        {
            _outputProvider("Hey! Lets start the game. Guess the number!");
            _randomNumber = new SecretNumber();
            TryToGuess();
        }

        private int? GetInputNumber()
        {
            _outputProvider("Input your number (0 - 100):");
            bool isInteger = false;
            int? result = null;
            while (!isInteger)
            {
                if (int.TryParse(_inputProvider(), out int value) && value >= 0 && value <= 100)
                {
                    result = value;
                    isInteger = true;
                }
                else
                {
                    _outputProvider("Invalid input. Please input int(0 - 100):");
                }
            }
            return result;
        }

        private bool VerifyValidation(int? inputNumber)
        {
            int processedNumber = _randomNumber.Validation(inputNumber);
            if (processedNumber == 0)
            {
                _outputProvider("Congratulations! You win!");
                return true;
            }            
            else return false;
        }

        private void BiggerOrSmaler(int? inputNumber)
        {
            int processedNumber = _randomNumber.Validation(inputNumber);
            if (processedNumber == 1)
            {
                _outputProvider("My number is bigger.");
            }
            else if (processedNumber == -1)
            {
                _outputProvider("My number is smaller.");
            }
        }

        private void TryToGuess()
        {
            bool isGuessed = false;
            while (!isGuessed)
            {
                int? processedNumber = GetInputNumber();
                isGuessed = VerifyValidation(processedNumber);
                if (!isGuessed)
                {
                    BiggerOrSmaler(processedNumber);
                }
            }
            return;
        }

        private void InitiateNewGameOrClose()
        {
            bool closeTheGame = false;
            while (!closeTheGame)
            {
                _outputProvider("Do you want to play again? Press 'y' for yes, for closing press 'n'.");
                string? c = Console.ReadLine();
                switch (c)
                {
                    case "y": { StartNewGame(); break; }

                    case "n": { closeTheGame = true; break; }
                }
            }
        }
    }
}

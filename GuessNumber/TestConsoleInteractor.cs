using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class TestConsoleInteractor
    {
        public void PrintGameStartMessage()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hey! Lets start the game. Guess the number!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PrintAskNewGameInitialize()
        {
            Console.WriteLine("Do you want to play again? Press 'y' for yes, for closing press 'n'.");
        }
         public void PrintCongratulations()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations! You win!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintNumberBigger()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("My number is bigger.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void PrintNumberSmaller()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("My number is smaller.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

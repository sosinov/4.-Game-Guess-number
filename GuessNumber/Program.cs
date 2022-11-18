using GuessNumber;

namespace Programm
{
    class Program
    {
        public static void Main()
        {
            GameProcessor game = new GameProcessor(Console.ReadLine, Console.WriteLine);
            Console.WriteLine("The end.");
        }
    }
}
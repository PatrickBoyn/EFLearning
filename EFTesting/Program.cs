using System;

namespace EFTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            int result = -1;
            while (result != 9)
            {
                result = MainMenu();
            }
        }
    }
}

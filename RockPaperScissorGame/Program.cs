using System;
// Removed unused classes...

namespace RockPaperScissorGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Result game = new Result();

            while (game.playAgain)
            {
                
                Console.WriteLine("\nWelcome To rock-paper-scissor game!");
                Console.WriteLine("Press \"R\" for rock, \"S\" for scissors & \"P\" for paper\n");

                game.Status();
            }
        }
    }
}

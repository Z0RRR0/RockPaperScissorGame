using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    internal class Result
    {
        public bool playAgain = true;
        public void Status()
        {
            Player player = new Player();
            player.PlayerKey();
            ConsoleKeyInfo cki;

            Bot bot = new Bot();
            bot.BotKey();

            if ((player.playerPaper && bot.botPaper) || (player.playerRock && bot.botRock) || (player.playerScissor && bot.botScissor)) Console.WriteLine("\nIt's a Draw");
            else if ((player.playerPaper && bot.botScissor) || (player.playerScissor && bot.botRock) || (player.playerRock && bot.botPaper)) Console.WriteLine("\nBot won the game");
            else if ((player.playerPaper && bot.botRock) || (player.playerScissor && bot.botPaper) || (player.playerRock && bot.botScissor)) Console.WriteLine("\nPlayer won the game");

            while (true)
            {
                Console.WriteLine("Presss \"Enter\" to play again or \"Esc\" to exit\n");

                while (true)
                {
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        playAgain = true;
                        Console.Clear();
                        break;
                    }
                    else if (cki.Key == ConsoleKey.Escape)
                    {
                        playAgain = false;
                        Console.Clear();
                        break;
                    }
                    else Console.WriteLine("Wtf? are you serious bruhh..? Dayumm...!\n");
                }
                break;
            }
        }
    }
}

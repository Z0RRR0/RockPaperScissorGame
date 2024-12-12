using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    internal class Player
    {
        public bool playerRock = false;
        public bool playerScissor = false;
        public bool playerPaper = false;

        ConsoleKeyInfo cki;
        public void PlayerKey()
        {
            while(true){ 
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.R || cki.Key == ConsoleKey.P) {
                    if (cki.Key == ConsoleKey.R)
                    {
                        playerRock = true;
                        break;
                    }
                    if (cki.Key == ConsoleKey.S)
                    {
                        playerScissor = true;
                        break;
                    }
                    if (cki.Key == ConsoleKey.P)
                    {
                        playerPaper = true;
                        break;
                    }
                }
                else Console.WriteLine("\nChoose Wisely between \"R\" for rock, \"P\" for paper and \"S\" for scissor");
            } 
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorGame
{
    internal class Bot
    {
        public bool botRock = false;
        public bool botPaper = false;
        public bool botScissor = false;

        int bot;
        Random random = new Random();
        public void BotKey()
        {
            bot = random.Next(1, 4);
            switch(bot)
            {
                case 1: 
                    botRock = true;
                    break;
                case 2:
                    botPaper = true;
                    break;
                case 3:
                    botScissor = true;
                    break;
            }
        }
        
    }

    
}

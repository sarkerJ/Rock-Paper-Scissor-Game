using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public class BotPlayer : Player
    {
        public static Random rand = new Random();
        public Array moveValues = Enum.GetValues(typeof(Move));


        //Setting the bot name and the first move
        public BotPlayer()
        {
            PlayerName = "BotGenius";
            GetMove();
        }

        public Move GetMove()
        {
            Move = (Move)moveValues.GetValue(rand.Next(moveValues.Length));
            return Move;
        }

    }
}

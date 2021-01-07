using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public class BotPlayer : Player
    {
        public static Random rand = new Random();
        public Array moveValues = Enum.GetValues(typeof(Movess));


        //Setting the bot nameW
        public BotPlayer()
        {
            PlayerName = "BotGenius";
        }

        public Movess GetMove()
        {
            Move = (Movess)moveValues.GetValue(rand.Next(moveValues.Length));
            return Move;
        }

    }
}

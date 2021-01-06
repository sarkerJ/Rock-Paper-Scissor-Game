using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public abstract class Player : IPlayer
    {
        public string PlayerName { get; set; }
        public Move Move { get; set; }
    }
}

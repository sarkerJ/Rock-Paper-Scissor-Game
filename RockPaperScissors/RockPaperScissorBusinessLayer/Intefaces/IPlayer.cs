using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public interface IPlayer
    {
        public string PlayerName { get; set; }
        public Movess Move { get; set; }

        public int Score { get; set; }
    }
}

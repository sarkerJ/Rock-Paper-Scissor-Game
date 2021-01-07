using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer.Intefaces
{
    public interface IGame
    {
        string GameResult();
        string GameResult(Movess playerOneMove, Movess playerTwoMove);
        IPlayer PlayerOne { get; set; }
        IPlayer PlayerTwo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorBusinessLayer.Intefaces
{
    public interface IGame
    {
        string GameResult();
        string GameResult(Move playerOneMove, Move playerTwoMove);
        IPlayer PlayerOne { get; set; }
        IPlayer PlayerTwo { get; set; }
    }
}

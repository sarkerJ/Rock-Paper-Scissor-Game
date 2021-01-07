using System;
using System.Collections.Generic;
using RockPaperScissorBusinessLayer.Intefaces;
using System.Text;

namespace RockPaperScissorBusinessLayer
{
    public class Game : IGame
    {
        public IPlayer PlayerOne { get; set; }
        public IPlayer PlayerTwo { get; set; }

        public Game(IPlayer playerOne, IPlayer playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        public string GameResult()
        {
            return GameResult(PlayerOne.Move, PlayerTwo.Move);
        }

        public string GameResult(Movess playerOneMove, Movess playerTwoMove)
        {
            string result = "It is a Draw!";

            if ((playerOneMove == Movess.Rock && playerTwoMove == Movess.Scissors) ||
                (playerOneMove == Movess.Paper && playerTwoMove == Movess.Rock) ||
                (playerOneMove == Movess.Scissors && playerTwoMove == Movess.Paper))
            {
                result = $"{PlayerOne.PlayerName} Scores!";
                PlayerOne.Score += 1;
            }

            if ((playerTwoMove == Movess.Rock && playerOneMove == Movess.Scissors) ||
               (playerTwoMove == Movess.Paper && playerOneMove == Movess.Rock) ||
               (playerTwoMove == Movess.Scissors && playerOneMove == Movess.Paper))
            {
                result = $"{PlayerTwo.PlayerName} Scores!";
                PlayerTwo.Score += 1;
            }

            return result;
        }
    }
}

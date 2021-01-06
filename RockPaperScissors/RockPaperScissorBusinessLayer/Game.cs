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

        public string GameResult(Move playerOneMove, Move playerTwoMove)
        {
            string result = "It is a Draw!";

            if ((playerOneMove == Move.Rock && playerTwoMove == Move.Scissors) ||
                (playerOneMove == Move.Paper && playerTwoMove == Move.Rock) ||
                (playerOneMove == Move.Scissors && playerTwoMove == Move.Paper))
            {
                result = $"{PlayerOne.PlayerName} Scores!";
                PlayerOne.Score += 1;
            }

            if ((playerTwoMove == Move.Rock && playerOneMove == Move.Scissors) ||
               (playerTwoMove == Move.Paper && playerOneMove == Move.Rock) ||
               (playerTwoMove == Move.Scissors && playerOneMove == Move.Paper))
            {
                result = $"{PlayerTwo.PlayerName} Scores!";
                PlayerTwo.Score += 1;
            }

            return result;
        }
    }
}

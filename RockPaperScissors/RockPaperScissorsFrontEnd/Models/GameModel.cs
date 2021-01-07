using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockPaperScissorBusinessLayer.Intefaces;
using RockPaperScissorBusinessLayer;

namespace RockPaperScissorsFrontend.Models
{
    

    public class GameModel
    {
        public GameModel()
        {
            playerOne = new HumanPlayer();
            playerTwo = new BotPlayer();
        }



        public IPlayer playerOne { get; set; }
        public IPlayer playerTwo { get; set; }
        public string result { get; set; }
    }

    
}

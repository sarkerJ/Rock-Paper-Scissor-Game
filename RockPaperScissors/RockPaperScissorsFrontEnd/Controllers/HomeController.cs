﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RockPaperScissorsFrontend.Models;
using RockPaperScissorBusinessLayer.Intefaces;
using RockPaperScissorBusinessLayer;

namespace RockPaperScissorsFrontend.Controllers
{
    public class HomeController : Controller
    {
        //Created a static model to ensure that the model is stored even after the Get method and the Post method end
        // without static the model turns to null after GetGame is returned and refreshes the page
        //static also means the player scores are now saved!
        public static GameModel gameM; 

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Instructions()
        {
            return View();
        }

        [HttpGet]
        [ActionName("Game")]
        public IActionResult GetGame()
        {
            gameM = new GameModel();
            gameM.result = "Empty";
            return View(gameM);
        }

        [HttpPost]
        //[ActionName("Game")]
        public IActionResult PostGame(Movess move)
        {
            if(gameM != null)
            {
                gameM.playerOne.Move = move;
                gameM.result = string.Empty;
                BotPlayer currentBot = (BotPlayer)gameM.playerTwo;
                gameM.playerTwo.Move = currentBot.GetMove();
                IGame game = new Game(gameM.playerOne, gameM.playerTwo);

                gameM.result = game.GameResult();

            }
            
            
            return Json( new { Data = gameM });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

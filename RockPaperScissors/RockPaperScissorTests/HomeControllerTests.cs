using NUnit.Framework;
using RockPaperScissorBusinessLayer;
using RockPaperScissorsFrontend.Controllers;
using RockPaperScissorsFrontend.Models;
using Newtonsoft.Json;

namespace RockPaperScissorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("ViewReturned-HomeController")]
        [Test]
        public void GivenTheIndexMethod_TheIndexView_IsReturned()
        {
            //Arrange
            var homecrl = new HomeController();
            //Act
            var result = homecrl.Index();
            //Assert
            Assert.That(result, Is.InstanceOf<Microsoft.AspNetCore.Mvc.ViewResult>());
        }

        [Category("ViewReturned-HomeController")]
        [Test]
        public void GivenTheInstructionMethod_TheInstructionView_IsReturned()
        {
            //Arrange
            var homecrl = new HomeController();
            //Act
            var result = homecrl.Instructions();
            //Assert
            Assert.That(result, Is.InstanceOf<Microsoft.AspNetCore.Mvc.ViewResult>());
        }

        [Category("ViewReturned-HomeController")]
        [Test]
        public void GivenTheGetGameMethod_TheGameView_IsReturned()
        {
            //Arrange
            var homecrl = new HomeController();
            //Act
            var result = homecrl.GetGame();
            //Assert
            Assert.That(result, Is.InstanceOf<Microsoft.AspNetCore.Mvc.ViewResult>());
        }

        [Category("ViewResults-GetGame-HomeController")]
        [Test]
        public void GetGame_Returns_AGameViewResult_With_DefaultValues()
        {
            //Arrange
            var homecrl = new HomeController();
            var result = homecrl.GetGame();
            //Act
            var viewResult = (Microsoft.AspNetCore.Mvc.ViewResult)result;
            var model = (GameModel)viewResult.Model;
            //Assert
            Assert.That(model.result, Is.EqualTo("Empty"));
            Assert.That(model.playerOne.Score, Is.EqualTo(0));
            Assert.That(model.playerTwo.Score, Is.EqualTo(0));

        }

        [Category("ViewReturned-HomeController")]
        [Test]
        public void GivenThePostGameMethod_TheGame_JsonView_IsReturned()
        {
            //Arrange
            var homecrl = new HomeController();
            //Act
            var result = homecrl.PostGame(Movess.Rock);
            //Assert
            Assert.That(result, Is.InstanceOf<Microsoft.AspNetCore.Mvc.JsonResult>());
        }


        [Category("ViewResults-PostGame-HomeController")]
        [Ignore("Unsure how to conver json {new data  = obj} returned from PostGame to the normal GameModel")]
        [Test]
        public void PostGame_Returns_AGameViewWith_DefaultValues()
        {
            //Arrange
            var homecrl = new HomeController();
            homecrl.GetGame();
            var result = homecrl.PostGame(Movess.Rock);
            //Act
            var viewResult = (Microsoft.AspNetCore.Mvc.JsonResult)result;
            var model = JsonConvert.DeserializeObject(viewResult.ToString());
            var x = model;


            //Assert
            Assert.That(model, Is.EqualTo("Empty"));

        }
    }
}
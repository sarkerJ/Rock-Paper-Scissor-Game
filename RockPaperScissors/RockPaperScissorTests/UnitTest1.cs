using NUnit.Framework;
using RockPaperScissorBusinessLayer;

namespace RockPaperScissorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Category("HumanPlayer")]
        [TestCase("Tester", "Tester")]
        [TestCase("James", "James")]
        [TestCase("Robin", "Robin")]
        public void GivenAUserName_TheHumanPlayerConstructor_SavesTheCorrectName(string input, string expected)
        {
            var testPlayer = new HumanPlayer(input);
            Assert.That(testPlayer.PlayerName, Is.EqualTo(expected));
        }

        [Category("HumanPlayer")]
        [Test]
        public void GivenNoParameters_TheHumanPlayerContructor_SetsTheDefaultString_AsThePlayerName()
        {
            var testPlayer = new HumanPlayer();
            Assert.That(testPlayer.PlayerName, Is.EqualTo("PlayerOne"));
        }

        [Category("BotPlayer")]
        [Test]
        public void CreatingABotClass_SavesThePlayerNameAs_BotGenius()
        {
            var testPlayer = new BotPlayer();
            Assert.That(testPlayer.PlayerName, Is.EqualTo("BotGenius"));
        }


        [Category("BotPlayer")]
        [Test]
        public void GivenABotClass_GetMove_ReturnsAn_EnEnumMoveValue()
        {
            //Arrange
            var testPlayer = new BotPlayer();
            //Act
            var result = testPlayer.GetMove();
            //Assert
            Assert.That(result, Is.InstanceOf<Movess>());
        }


        [Category("Game")]
        [TestCase(Movess.Rock, Movess.Scissors, "James Scores!")]
        [TestCase(Movess.Paper, Movess.Rock, "James Scores!")]
        [TestCase(Movess.Scissors, Movess.Paper, "James Scores!")]
        [TestCase(Movess.Scissors, Movess.Rock, "BotGenius Scores!")]
        [TestCase(Movess.Rock, Movess.Paper, "BotGenius Scores!")]
        [TestCase(Movess.Paper, Movess.Scissors, "BotGenius Scores!")]
        [TestCase(Movess.Scissors, Movess.Scissors, "It is a Draw!")]
        [TestCase(Movess.Rock, Movess.Rock, "It is a Draw!")]
        [TestCase(Movess.Paper, Movess.Paper, "It is a Draw!")]
        public void GivenTwoMoves_GameResult_ReturnsTheCorrectString(Movess playerOneMove, Movess playerTwoMove, string expected)
        {
            //Arrange
            var one = new HumanPlayer("James");
            var two = new BotPlayer();
            var game = new Game(one, two);
            //Act
            var result = game.GameResult(playerOneMove, playerTwoMove).Trim();
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }


        [Category("Game")]
        [Test]
        public void GivenTheFactThatTheUserWins_TheUserScore_IncreasesByOne()
        {
            //Arrange
            var one = new HumanPlayer();
            var two = new BotPlayer();
            var game = new Game(one, two);
            //Act
            game.PlayerOne.Move = Movess.Rock;
            game.PlayerTwo.Move = Movess.Scissors;
            game.GameResult();
            //Assert
            Assert.That(game.PlayerOne.Score, Is.EqualTo(1));
        }

        [Category("Game")]
        [Test]
        public void GivenTwoMovesAreTheSame_TheScoreRemainsTheSame()
        {
            //Arrange
            var one = new HumanPlayer();
            var two = new BotPlayer();
            var game = new Game(one, two);
            //Act
            game.PlayerOne.Move = Movess.Rock;
            game.PlayerTwo.Move = Movess.Rock;
            game.GameResult();
            //Assert
            Assert.That(game.PlayerOne.Score, Is.EqualTo(0));
            Assert.That(game.PlayerTwo.Score, Is.EqualTo(0));

        }
    }
}
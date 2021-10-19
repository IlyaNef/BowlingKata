using BowlingGame;
using BowlingGameTests.DSL;
using NUnit.Framework;

namespace BowlingGameTests
{
    public class BowlingGameTests
    {
        [Test]
        public void TestGutterGame()
        {
            var game = Create.Game().Please();
            game.RollMany(20, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            var game = Create.Game().Please();
            game.RollMany(20, 1);
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            var game = Create.Game()
                .WithCountOfPlayers(2)
                .Please();
            
            game.RollSpare()
                .RollOne(3)
                .RollMany(17, 0);
            Assert.AreEqual(16, game.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            var game = Create.Game().Please();
            game.RollStrike()
                .RollOne(3)
                .RollOne(5)
                .RollMany(17, 0);
            Assert.AreEqual(26, game.Score());
        }

        [Test]
        public void TestPerfectGame()
        {
            var game = Create.Game().Please();
            game.RollMany(12, 10);
            Assert.AreEqual(300, game.Score());
        }
    }
    
    public static class GameExtensions
    {
        public static Game RollMany(this Game game, int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }

            return game;
        }
        
        public static Game RollSpare(this Game game)
        {
            game.Roll(3);
            game.Roll(7);
            return game;
        }

        public static Game RollStrike(this Game game)
        {
            game.Roll(10);
            return game;
        }

        public static Game RollOne(this Game game, int pins)
        {
            game.Roll(pins);
            return game;
        }
    }
}
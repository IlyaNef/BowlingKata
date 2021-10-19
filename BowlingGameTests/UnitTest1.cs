using BowlingGame;
using NUnit.Framework;


namespace BowlingGameTests
{
    public class Tests
    {
        [Test]
        public void TestGutterGame()
        {
            var g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(0);
            }
            Assert.Pass();
        }
    }
}
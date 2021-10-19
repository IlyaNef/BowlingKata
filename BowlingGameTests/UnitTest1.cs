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
            Assert.AreEqual(0, g.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            var g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);
            }
            Assert.AreEqual(20, g.Score());
        }
    }
}
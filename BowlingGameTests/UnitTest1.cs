using BowlingGame;
using NUnit.Framework;


namespace BowlingGameTests
{
    public class Tests
    {
        private Game _g;
        
        [SetUp]
        protected void SetUp()
        {
            _g = new();
        }
        
        [Test]
        public void TestGutterGame()
        {
            RollMany(20, 0);
            Assert.AreEqual(0, _g.Score());
        }

        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, _g.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            _g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, _g.Score());
        }

        [Test]
        public void TestOneStrike()
        {
            _g.Roll(10);
            _g.Roll(3);
            _g.Roll(5);
            RollMany(17, 0);
            Assert.AreEqual(26, _g.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                _g.Roll(pins);
            }
        }

        private void RollSpare()
        {
            _g.Roll(3);
            _g.Roll(7);
        }
    }
}
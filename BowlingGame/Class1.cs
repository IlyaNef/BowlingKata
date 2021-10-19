using System;

namespace BowlingGame
{
    public class Game
    {
        private int _score = 0;
        public void Roll(int i)
        {
            _score += i;
        }

        public int Score()
        {
            return _score;
        }
    }
}
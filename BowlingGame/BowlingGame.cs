using System;
using System.Runtime.InteropServices;

namespace BowlingGame
{
    public class Game
    {
        private int[] _rolls = new int[21];
        private int _currentRoll = 0;

        public Game(int playersCount)
        { }

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            int score = 0;
            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if (_rolls[frameIndex] == 10)
                {
                    score += 10 + _rolls[frameIndex + 1] + _rolls[frameIndex + 2];
                    frameIndex += 1;
                }
                else if (IsSpare(frameIndex))
                {
                    score += 10 + _rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    score += _rolls[frameIndex] + _rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return score;
        }

        private bool IsSpare(int frameIndex)
        {
            return _rolls[frameIndex] + _rolls[frameIndex + 1] == 10;
        }
    }
}
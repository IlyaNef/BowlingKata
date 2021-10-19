using BowlingGame;

namespace BowlingGameTests.DSL
{
    public class GameBuilder
    {
        private Game _game = new();
        public Game Please()
        {
            return _game;
        }
    }
}
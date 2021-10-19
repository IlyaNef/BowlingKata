using BowlingGame;

namespace BowlingGameTests.DSL
{
    public class GameBuilder
    {
        private int _playersCount = 1;
        public Game Please()
        {
            var game = new Game(_playersCount);
            return game;
        }

        public GameBuilder WithCountOfPlayers(int playersCount)
        {
            _playersCount = playersCount;
            return this;
        }
    }
}
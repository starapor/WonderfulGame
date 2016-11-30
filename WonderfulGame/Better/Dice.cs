using System;
using WonderfulGame.GrowsTo;
using WonderfulGame.Starts;

namespace WonderfulGame.Better
{
    class Dice : IDice
    {
        private readonly Random _random;

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll()
        {
            return _random.Next(1,6);
        }
    }

    class SkipEverySecondRoll : IDice
    {
        private readonly IDice _dice;

        public SkipEverySecondRoll(IDice dice)
        {
            _dice = dice;
        }

        public int Roll()
        {
            var ignoreThisValue = _dice.Roll();
            return _dice.Roll();
        }
    }

    class DiceLogger : IDice
    {
        private readonly IDice _dice;
        private readonly ILogger _logger;

        public DiceLogger(IDice dice, ILogger logger)
        {
            _dice = dice;
            _logger = logger;
        }

        public int Roll()
        {
            var rolledNumber = _dice.Roll();
            _logger.Log("We just rolled an awesome random number {0}", rolledNumber);
            return rolledNumber;
        }
    }
}

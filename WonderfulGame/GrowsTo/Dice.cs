using System;
using WonderfulGame.Starts;

namespace WonderfulGame.GrowsTo
{
    class Dice : IDice
    {
        private readonly ILogger _logger;
        private readonly bool _skipEverySecondRoll;
        private readonly Random _random;
        
        public Dice(Random random, ILogger logger, bool skipEverySecondRoll)
        {
            _random = random;
            _logger = logger;
            _skipEverySecondRoll = skipEverySecondRoll;
        }

        public int Roll()
        {
            var randomNumber =  _random.Next(1,6);
            _logger.Log("We just rolled an awesome random number {0}", randomNumber);
            if (_skipEverySecondRoll)
            {
                randomNumber = _random.Next(1, 6);
            }
            return randomNumber;
        }
    }
}

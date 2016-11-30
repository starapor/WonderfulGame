using System;

namespace WonderfulGame.Starts
{
    public interface IDice
    {
        int Roll();
    }

    class Dice : IDice
    {
        private readonly Random _random;

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll()
        {
            var randomNumber =  _random.Next(1,6);
            return randomNumber;
        }
    }
    
}

namespace WonderfulGame.Better
{
    public class Game
    {
        private readonly Matcher<Player> _matcher;

        public Game()
        {
            _matcher = new Matcher<Player>
            {
                {  p => p.InPenaltyBox(), ReducePenaltyTime  },
                {  p => p.WearingAHat(),  RemoveTheHat  },
                {  p => true,             PlayARound }
            };
        }

        public void TakeTurn(Player player)
        {
            _matcher.DoActionThatMatches(player);
        }

        public void ReducePenaltyTime() { }
        public void PlayARound() { }
        public void RemoveTheHat() { }
    }
}
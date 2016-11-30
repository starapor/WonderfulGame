namespace WonderfulGame.GrowsTo
{
    public class Game
    {
        public void TakeTurn(Player player)
        {
            if (player.InPenaltyBox())
                ReducePenaltyTime();
            else if (player.WearingAHat())
                RemoveTheHat();
            else
                PlayARound();
        }

        public void ReducePenaltyTime() { }
        public void PlayARound() { }
        public void RemoveTheHat() { }
    }
}
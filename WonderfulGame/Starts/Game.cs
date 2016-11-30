namespace WonderfulGame.Starts
{
    public class Game
    {
        public void TakeTurn(Player player)
        {
            if (player.InPenaltyBox())
                ReducePenaltyTime();
            else
                PlayARound();
        }
        
        public void ReducePenaltyTime() { }
        public void PlayARound() { }
        
    }
}
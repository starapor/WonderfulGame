namespace WonderfulGame.Starts
{
    public class Player
    {
        private readonly string _name;

        public Player(string name)
        {
            _name = name;
        }

        public bool InPenaltyBox() { return true; }
        public bool WearingAHat() { return true; }
    }
}
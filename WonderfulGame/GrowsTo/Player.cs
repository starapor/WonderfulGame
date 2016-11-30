namespace WonderfulGame.GrowsTo
{
    public class Player
    {
        private readonly string _name;
        private readonly string _nickname;
        private readonly string _email;

        public Player(string name, string nickname, string email)
        {
            _name = name;
            _nickname = nickname;
            _email = email;
        }

        public bool InPenaltyBox() { return true; }
        public bool WearingAHat() { return true; }
    }
}
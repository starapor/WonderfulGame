namespace WonderfulGame.Better
{
    public class Player
    {
        private readonly string _name;
        private readonly string _nickname;
        private readonly string _email;

        public Player(Name name, Nickname nickname, Email email)
        {
            _name = name;
            _nickname = nickname;
            _email = email;
        }

        public bool InPenaltyBox() { return true; }
        public bool WearingAHat() { return true; }
    }


	public class Name : TinyType<string> { public Name(string value) : base(value) { } }
	public class Nickname : TinyType<string> { public Nickname(string value) : base(value) { } }
	public class Email : TinyType<string> { public Email(string value) : base(value) { } }

	public class TinyType<T>
	{
		private readonly T _value;
		public TinyType(T value) {_value = value;}
		public static implicit operator T(TinyType<T> tt) { return tt._value; }
		public static implicit operator TinyType<T>(T value) { return new TinyType<T>(value); }
	}

}
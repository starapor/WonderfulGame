using WonderfulGame.Starts;

namespace WonderfulGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GrowsTo.Game game2 =  new GrowsTo.Game();
            Better.Game betterGame = new Better.Game();


            GrowsTo.Player player2 = new GrowsTo.Player("Fred", "Fred", "Fred@me.com");
        }
    }
}

namespace WonderfulGame.GrowsTo
{
    public interface ILogger
    {
        void Log(string message, int randomNumber);
    }

    class Logger : ILogger
    {
        public void Log(string message, int randomNumber)
        {
            throw new System.NotImplementedException();
        }
    }
}
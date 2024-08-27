namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo (string message);
        void LoggWarn(string message);
        void LogDebug(string message);
        void LogError (string message);
    }
}
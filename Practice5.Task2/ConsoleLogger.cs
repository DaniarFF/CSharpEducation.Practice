namespace Practice5.Task2
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message, LogType logLevel)
        {
            string logMessage = $"{DateTime.Now} | {nameof(ConsoleLogger)} | {logLevel} | {message}"; 
            Console.WriteLine(logMessage);
        }
        public void Trace(string message) => Log(message, LogType.Trace);
        public void Info(string message) => Log(message, LogType.Info);
        public void Debug(string message) => Log(message, LogType.Debug);
        public void Warning(string message) => Log(message, LogType.Warning);
        public void Error(string message) => Log(message, LogType.Error);
        public void Fatal(string message) => Log(message, LogType.Fatal);
    }

    public interface ILogger
    {
        void Log(string message, LogType logLevel);
    }

    public enum LogType
    {
        Trace,
        Info,
        Debug,
        Warning,
        Error,
        Fatal
    }
}

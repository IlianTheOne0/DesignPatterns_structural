namespace ClassLibrary.StructuralPatterns.Adapter;

public interface ILogger
{
    void Log(string message);
}

public class OldLogger : ILogger
{
    public void Log(string message) { Console.WriteLine($"[Old logger] {message}"); }
}

public class LoggerAdapter : ILogger
{
    private readonly ILogger _logger;

    public LoggerAdapter(ILogger logger) => _logger = logger;

    public void Log(string message) { _logger.Log($"[New logger] {message}"); } 
}
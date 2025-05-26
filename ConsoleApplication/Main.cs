namespace ClassLibrary.StructuralPatterns.Adapter;

internal class Client
{
    public static void Main(string[] args)
    {
        ILogger logger0 = new OldLogger();
        Console.WriteLine("App: Launched with the OldLogger.");
        logger0.Log("Hello world!");

        ILogger logger1 = new LoggerAdapter(logger0);
        Console.WriteLine("App: Launched with the addoted logger.");
        logger1.Log("New hello world!");
    }
}
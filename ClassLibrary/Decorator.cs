namespace ClassLibrary.StructuralPatterns.Decorator;

public interface IMessenger
{
    string Send(string message);
}

public class Base : IMessenger
{
    private IMessenger _messenger;

    public Base(IMessenger messenger) => _messenger = messenger;

    public virtual string Send(string message) => _messenger.Send(message);
}

public class Mobile : IMessenger
{
    public string Name { get; set; }

    public Mobile(string name) => Name = name;

    public string Send(string message) => $"Mobile {Name} send \"{message}\"";
}

public class Web : IMessenger
{
    public string Name { get; set; }

    public Web(string name) => Name = name;

    public string Send(string message) => $"Web {Name} send \"{message}\"";
}

public class Server : IMessenger
{
    public string Name { get; set; }

    public Server(string name) => Name = name;

    public string Send(string message) => $"Server {Name} send \"{message}\"";
}
namespace ClassLibrary.StructuralPatterns.Decorator;

internal class Program
{
    public static void NotificationService(List<IMessenger> components, string message)
    {
        foreach (IMessenger component in components) { Console.WriteLine(component.Send(message)); }
        Console.WriteLine();
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("App: Creating notifiers.");
        IMessenger mobileNotify = new Mobile("Samsung A51");
        IMessenger webNotify = new Web("Web");
        IMessenger serverNotify = new Server("Linux server");

        Console.WriteLine();

        Console.WriteLine("App: Adding mobile notifiers.");
        List<IMessenger> forMobileNotification = new List<IMessenger>();
        forMobileNotification.Add(new SMS(mobileNotify));

        Console.WriteLine();

        Console.WriteLine("App: Adding web notifiers.");
        List<IMessenger> forWebNotification = new List<IMessenger>();
        forWebNotification.Add(new Email(webNotify));
        forWebNotification.Add(new Facebook(webNotify));
        forMobileNotification.Add(new Twitter(webNotify));
        
        Console.WriteLine();

        Console.WriteLine("App: Adding server notifiers.");
        List<IMessenger> forServerNotification = new List<IMessenger>();

        Console.WriteLine();

        Console.WriteLine("App: Running notigiers.");
        NotificationService(forMobileNotification, "Recall me, please!");
        NotificationService(forWebNotification, "Hello! Can I call you?");
        NotificationService(forServerNotification, "Task #4321 from Jira moved to Done.");
    }
}
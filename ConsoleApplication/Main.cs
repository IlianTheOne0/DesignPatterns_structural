namespace ClassLibrary.StructuralPatterns.Proxy;

internal class Client
{
    static void Main(string[] args)
    {
        Console.WriteLine("App: Creating proxies.");
        Proxy adminDoc = new Proxy("TOP SECRET DATA", "Admin");
        Proxy userDoc = new Proxy("TOP SECRET DATA", "User");
        Proxy guestDoc = new Proxy("TOP SECRET DATA", "Guest");

        Console.WriteLine();

        Console.WriteLine("App: Admin tries to view document.");
        adminDoc.ViewDocument();
        
        Console.WriteLine();

        Console.WriteLine("App: Admin tries to view document.");
        userDoc.ViewDocument();
        
        Console.WriteLine();

        Console.WriteLine("App: Admin tries to view document.");
        guestDoc.ViewDocument();
    }
}
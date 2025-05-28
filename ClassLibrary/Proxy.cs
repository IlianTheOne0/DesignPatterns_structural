namespace ClassLibrary.StructuralPatterns.Proxy;

public class Proxy : Interface
{
    private Real _document;
    private readonly string _content;
    private readonly string _userRole;

    public Proxy(string content, string userRole) { _content = content; _userRole = userRole; }

    public void ViewDocument()
    {
        if (_userRole != "Admin") { Console.WriteLine("Access denied! Admins only."); return; }

        _document ??= new Real(_content);
        _document.ViewDocument();
    }
}
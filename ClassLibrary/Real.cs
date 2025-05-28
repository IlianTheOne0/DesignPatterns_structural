namespace ClassLibrary.StructuralPatterns.Proxy;

public class Real : Interface
{
    private readonly string _content;

    public Real(string content) => _content = content;

    public void ViewDocument() => Console.WriteLine($"Document content: {_content}");
}
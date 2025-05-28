namespace ClassLibrary.CreationalPatterns.Flyweight;

public class CharacterFactory
{
    private readonly Dictionary<string, ICharacter> _characters = new();

    public ICharacter GetCharacter(char symbol, string fontFamily = "Arial")
    {
        string key = $"{symbol}_{fontFamily}";

        if (!_characters.ContainsKey(key)) { Console.WriteLine($"Creating new flyweight for: {key}"); _characters[key] = new Character(symbol, fontFamily); }
        else { Console.WriteLine($"Reusing existing flyweight: {key}"); }

        return _characters[key];
    }

    public int TotalFlyweights => _characters.Count;
}

public class TextEditor
{
    private readonly List<Tuple<ICharacter, int, int, string, int>> _elements = new();
    private readonly CharacterFactory _factory;

    public TextEditor(CharacterFactory factory) => _factory = factory;

    public void AddCharacter(char c, int x, int y, string color, int fontSize, string fontFamily = "Arial")
    {
        ICharacter character = _factory.GetCharacter(c, fontFamily);
        _elements.Add(new Tuple<ICharacter, int, int, string, int>(character, x, y, color, fontSize));
    }

    public void RenderDocument()
    {
        Console.WriteLine("\nRendering document:");
        foreach (var element in _elements) { element.Item1.Display(element.Item2, element.Item3, element.Item4, element.Item5); }
    }
}
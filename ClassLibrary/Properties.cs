namespace ClassLibrary.CreationalPatterns.Flyweight;

public interface ICharacter
{
    void Display(int positionX, int positionY, string color, int fontSize);
}

public class Character : ICharacter
{
    private readonly char _symbol;
    private readonly string _fontFamily;

    public Character(char symbol, string fontFamily) { _symbol = symbol; _fontFamily = fontFamily; }

    public void Display(int positionX, int positionY, string color, int fontSize)
    {
        Console.WriteLine($"Character '{_symbol}' ({_fontFamily}) | Position: ({positionX},{positionY}) | Color: {color} | Size: {fontSize}pt");
    }
}
namespace ClassLibrary.CreationalPatterns.Flyweight;
class Program
{
    static void Main()
    {
        var factory = new CharacterFactory();
        var editor = new TextEditor(factory);

        editor.AddCharacter('H', 0, 0, "Black", 12);
        editor.AddCharacter('e', 10, 0, "Blue", 12);
        editor.AddCharacter('l', 20, 0, "Black", 14, "Times New Roman");
        editor.AddCharacter('l', 30, 0, "Red", 16);
        editor.AddCharacter('o', 40, 0, "Green", 12);
        editor.AddCharacter('!', 50, 0, "Black", 12);
        editor.AddCharacter('!', 60, 0, "Black", 12);

        Console.WriteLine($"\nTotal flyweights created: {factory.TotalFlyweights}");

        editor.RenderDocument();
    }
}
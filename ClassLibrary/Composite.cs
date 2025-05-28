namespace ClassLibrary.StructuralPatterns.Composite;
using ClassLibrary.StructuralPatterns.Composite.NGraphic;

public class Container : Graphic
{
    private List<Graphic> _children = new List<Graphic>();
    private readonly string _name;

    public Container(string name) { _name = name; }

    public void Draw(int gap)
    {
        Console.WriteLine($"{new string(' ', gap)}Composite: {_name}");
        foreach (Graphic child in _children) { child.Draw(gap + 4); }
    }

    public void Add(Graphic graphic) => _children.Add(graphic);
    public void Remove(Graphic graphic) => _children.Remove(graphic);
}

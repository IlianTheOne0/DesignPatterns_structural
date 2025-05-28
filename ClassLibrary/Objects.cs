namespace ClassLibrary.StructuralPatterns.Composite.Objects;
using ClassLibrary.StructuralPatterns.Composite.NGraphic;

public abstract class Object : Graphic
{
    protected string _name;

    public Object(string name) { _name = name; }


    public virtual void Draw(int gap) => Console.WriteLine($"{new string(' ', gap)}Object: {_name}");
    public virtual void Add(Graphic graphic) => throw new NotImplementedException();
    public virtual void Remove(Graphic graphic) => throw new NotImplementedException();
}

public class Circle : Object
{
    public Circle(string name) : base(name) { }

    public override void Draw(int gap) => Console.WriteLine($"{new string(' ', gap)}Circle: {_name}");
}

public class Rectangle : Object
{
    public Rectangle(string name) : base(name) { }

    public override void Draw(int gap) => Console.WriteLine($"{new string(' ', gap)}Rectangle: {_name}");
}
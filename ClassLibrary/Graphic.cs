namespace ClassLibrary.StructuralPatterns.Composite.NGraphic;

public interface Graphic
{
    public abstract void Draw(int gap);
    public abstract void Add(Graphic graphic);
    public abstract void Remove(Graphic graphic);
}
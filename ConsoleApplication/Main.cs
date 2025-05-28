namespace ClassLibrary.StructuralPatterns.Composite;
using ClassLibrary.StructuralPatterns.Composite.Objects;

internal class Client
{
    static void Main(string[] args)
    {
        Console.WriteLine("App: Creating circles.");
        Circle circle1 = new Circle("Red Circle");
        Circle circle2 = new Circle("Blue Circle");
        Circle circle3 = new Circle("Green Circle");

        Console.WriteLine();

        Console.WriteLine("App: Creating rectangles.");
        Rectangle rectangle1 = new Rectangle("Red Rectangle");
        Rectangle rectangle2 = new Rectangle("Blue Rectangle");
        Rectangle rectangle3 = new Rectangle("Green Rectangle");

        Console.WriteLine();

        Console.WriteLine("App: Creating containers.");
        Container container1 = new Container("Primary Container");
        Container container2 = new Container("Secondary Container");
        
        Console.WriteLine();

        Console.WriteLine("App: Filling containers.");
        container1.Add(circle1);
        container1.Add(rectangle1);
        container1.Add(container2);
        container2.Add(circle2);
        container2.Add(circle3);
        container1.Add(rectangle2);
        container1.Add(rectangle3);

        Console.WriteLine();

        Console.WriteLine("App: Calling draw method.");
        container1.Draw(0);
    }
}
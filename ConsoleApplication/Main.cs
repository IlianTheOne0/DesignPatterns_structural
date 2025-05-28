using ClassLibrary.StructuralPatterns.Facade;
using System.Reflection.PortableExecutable;

namespace ConsoleApplication;

internal class Client
{
    static void Main(string[] args)
    {
        IProcess process1 = new Process1();
        IProcess process2 = new Process2();
        IProcess process3 = new Process3();

        Facade facade = new Facade(process1, process2, process3);
        Console.WriteLine(facade.Operation1());
        Console.WriteLine();
        Console.WriteLine(facade.Operation2());
    }
}
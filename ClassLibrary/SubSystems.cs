namespace ClassLibrary.StructuralPatterns.Facade;

public interface IProcess
{
    string Operation(string action);
}

public class Process1 : IProcess
{
    public string Operation(string action) => $"Process1: {action}";
}

public class Process2 : IProcess
{
    public string Operation(string action) => $"Process2: {action}";
}

public class Process3 : IProcess
{
    public string Operation(string action) => $"Process3: {action}";
}
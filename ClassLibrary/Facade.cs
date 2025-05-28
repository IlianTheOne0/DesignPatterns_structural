namespace ClassLibrary.StructuralPatterns.Facade;

public class Facade
{
    private IProcess _process1;
    private IProcess _process2;
    private IProcess _process3;

    public Facade(IProcess process1, IProcess process2, IProcess process3) { _process1 = process1; _process2 = process2; _process3 = process3; }

    public string Operation1() => $"Video conversion:\n{_process1.Operation("Start")}\n{_process2.Operation("Run")}\n{_process3.Operation("Halt")}";
    public string Operation2() => $"Video conversion:\n{_process1.Operation("Ready")}\n{_process2.Operation("Go")}\n{_process3.Operation("Stop")}";
}
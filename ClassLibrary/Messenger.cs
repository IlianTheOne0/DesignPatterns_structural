namespace ClassLibrary.StructuralPatterns.Decorator;

public class Email : Base
{
    public Email(IMessenger component) : base(component) { }

    public override string Send(string message) => base.Send(message) + " by Email";
}

public class Facebook : Base
{
    public Facebook(IMessenger component) : base(component) { }

    public override string Send(string message) => base.Send(message) + " by Facebook";
}

public class SMS : Base
{
    public SMS(IMessenger component) : base(component) { }

    public override string Send(string message) => base.Send(message) + " by SMS";
}

public class Twitter : Base
{
    public Twitter(IMessenger component) : base(component) { }

    public override string Send(string message) => base.Send(message) + " by Twitter";
}
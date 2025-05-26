namespace ClassLibrary.CreationalPatterns.Bridge.Religion;

public enum Religion
{
    Christianity,
    Atheism
}

public interface IReligion
{
    Religion Religion { get; }
}

public class ChristianityReligion : IReligion
{
    public Religion Religion => Religion.Christianity;
}

public class AtheismReligion : IReligion
{
    public Religion Religion => Religion.Atheism;
}
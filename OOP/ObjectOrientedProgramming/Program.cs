
namespace MyNamespace;

/// Abstraction
/// 
public abstract class MyClass
{
    public virtual void Message(string text)
    {
        Console.WriteLine($"{text} from base class");
    }
}

public class SocondClass : MyClass
{
    public override void Message(string text)
    {
        //base.Message(text);

        Console.WriteLine($"{text} from base SocondClass");
    }
}


///  How Use
public class Program
{
    public static void Main()
    {
        SocondClass socondClass = new SocondClass();
        socondClass.Message("Some text...");
    }
}

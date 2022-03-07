using Extention_method;


/// Extension methods enable you to "add" methods to existing types 
/// without creating a new derived type, recompiling,
/// or otherwise modifying the original type.
/// 
public static class Program
{
    public static void Main()
    {
        string text = "some text...";
        Console.WriteLine(text.WordCount()); // Output: 12

        ExtentionMethodToClass ex = new ExtentionMethodToClass();
        ex.M5("Some text...");
    }
}
namespace Tutorial3.Inheritance;

public interface IMyInterface
{
    void DoSomething();  // Method without implementation

    string Name { get; set; }  // Property

    // Default method - with implementation
    void DefaultMethod()
    {
        Console.WriteLine("This is a default implementation of DefaultMethod.");
    }
}
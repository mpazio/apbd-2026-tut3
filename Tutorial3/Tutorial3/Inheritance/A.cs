namespace Tutorial3.Inheritance;

public class A : IMyInterface
{
    // Class properties
    public int Number { get; set; }  // Additional property specific to class A
    public string Name { get; set; }  // Implementation of a property from the interface
    public A(int number, string name)
    {
        Number = number;
        Name = name;
    }

    public virtual void DoSomething()
    {
        Console.WriteLine("A");
    }
}
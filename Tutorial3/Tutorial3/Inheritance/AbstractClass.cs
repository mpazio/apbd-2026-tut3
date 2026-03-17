namespace Tutorial3.Inheritance;

public abstract class AbstractClass
{
    // Property
    public string Name { get; set; }

    // Constructor of the abstract class
    public AbstractClass(string name)
    {
        Name = name;
    }

    // Implemented method (can be inherited without modification)
    public void PerformAction()
    {
        Console.WriteLine($"{Name} is performing an action.");
    }

    // Abstract method (must be implemented in derived classes)
    public abstract void SpecificAction();
}
namespace Tutorial3.Inheritance;

public class B : A
{
    // Additional property specific only to class B
    public int MyProperty { get; set; }

    // Constructor of class B, which initializes both the base class A properties and its own MyProperty
    public B(int number, string name, int myProperty) : base(number, name)
    {
        MyProperty = myProperty;
    }

    // Overriding the DoSomething method from class A
    public override void DoSomething()
    {
        Console.WriteLine("B");
    }
}
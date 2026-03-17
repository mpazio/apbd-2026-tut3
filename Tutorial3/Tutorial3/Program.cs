using Tutorial3.Inheritance;

{
    // Variable assignment
    int number = 10;      // Declaration of an int variable
    var t = "text";       // Using 'var' for a string type
    var i = 10;           // 'var' for an integer

    // Text operations

    // 1. Concatenating strings using the "+" operator
    string text = "Text: " + number + ".";  
    Console.WriteLine(text); // Prints: Text: 10.

    // 2. String interpolation
    string textWithDollar = $"Text: {number}.";
    Console.WriteLine(textWithDollar); // Prints: Text: 10.

    // 3. Using a verbatim string literal
    string textWithAtSign = @"C:\Users"; 
    Console.WriteLine(textWithAtSign); // Prints: C:\Users
}

// Nullable
{
    // Nullable int - a variable that can hold a numeric value or be null
    int? nullableInt = null;
    nullableInt = 4;

    // Nullable Object - an object that can be null or any object
    Object? o = null;

    if (nullableInt.HasValue)
    {
        Console.WriteLine($"The value of nullableInt is: {nullableInt.Value}");
    }
    else
    {
        Console.WriteLine("nullableInt is null");
    }
}

// Collections in C#
{
    // 1. List of int - stores only integer numbers
    var listOfIntegers = new List<int>();
    listOfIntegers.Add(10); 
    listOfIntegers.Add(20); 
    listOfIntegers.Add(30); 
    Console.WriteLine("List of numbers:");
    foreach (var num in listOfIntegers)
    {
        Console.WriteLine(num); 
    }

    // 2. Dictionary - stores key-value pairs
    var dictionary = new Dictionary<string, int>();
    dictionary.Add("key1", 100);
    dictionary.Add("key2", 200);

    Console.WriteLine("\nDictionary:");
    foreach (var pair in dictionary)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }

    // 3. HashSet collection - stores unique elements
    var uniqueNumbers = new HashSet<int>();
    uniqueNumbers.Add(10);
    uniqueNumbers.Add(20);
    uniqueNumbers.Add(10); // Adding 10 again (will not be added because HashSet stores only unique values)
    Console.WriteLine("\nHashSet (unique elements):");
    foreach (var num in uniqueNumbers)
    {
        Console.WriteLine(num); 
    }
}

// Exception handling
{
    try
    {
        // Throwing a general exception
        throw new Exception("An error occurred in the application.");
    }
    catch (Exception e)
    {
        // Handling a general exception
        Console.WriteLine($"Error: {e.Message}"); // Output: Error: An error occurred in the application.
    }
    
    try
    {
        // Specific exception: division by zero
        int x = 10;
        int y = 0;
        int result = x / y; // This will cause a DivideByZeroException
    }
    catch (DivideByZeroException e)
    {
        // Handling a specific exception
        Console.WriteLine($"Error: Attempted division by zero. {e.Message}");
    }
    
    // Finally block for resource cleanup
    try
    {
        Console.WriteLine("Starting operation...");
        // Simulated operation, e.g., closing a file or a database connection
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
    finally
    {
        // Cleanup operations that always run
        Console.WriteLine("Resources have been released.");
    }
    
    try
    {
        // Using a custom exception
        throw new CustomException("Database access error.");
    }
    catch (CustomException e)
    {
        // Handling a custom exception
        Console.WriteLine($"CustomException: {e.Message}");
    }
}

// Class usage
{
    A a = new A(1, "Nazwa");
    A b = new B(1, "NazwaB", 2);

    a.DoSomething();
    b.DoSomething();
}

// Custom exception
public class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}

using Exercise_1_SingletonPattern;

// Create two objects
Singleton obj1 = Singleton.GetInstance();
Singleton obj2 = Singleton.GetInstance();

// Call methods
obj1.DisplayMessage();
obj2.DisplayMessage();

Console.WriteLine();

// Display Hash Codes
Console.WriteLine($"Hash Code of obj1: {obj1.GetHashCode()}");
Console.WriteLine($"Hash Code of obj2: {obj2.GetHashCode()}");

Console.WriteLine();

// Check whether both objects are the same
if (obj1 == obj2)
{
    Console.WriteLine("Both objects are the SAME instance.");
}
else
{
    Console.WriteLine("Objects are DIFFERENT.");
}
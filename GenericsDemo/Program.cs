namespace GenericsDemo;

class Program
{
    static void PrintCollection<T>(T[] collection)
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }

    static void Main(string[] args)
    {
        // Generic class
        Box<int> intBox = new Box<int>(42);
        Box<string> stringBox = new Box<string>("Hello, World!");

        Console.WriteLine(intBox.GetItem());
        Console.WriteLine(stringBox.GetItem());

        // Generic method
        int[] intArray = [1, 2, 3, 4, 5];
        string[] stringArray = ["one", "two", "three", "four", "five"];

        PrintCollection(intArray);
        PrintCollection(stringArray);
    }
}

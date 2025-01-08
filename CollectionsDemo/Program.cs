namespace GenericsDemo;

class Program
{
    static void Main(string[] args)
    {
        // using a List
        List<string> names = new();
        names.Add("John");
        names.Add("Jane");
        names.Add("Mary");
        names.Add("Lee");
        names.Add("Fred");
        
        Console.WriteLine("Names List:");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Lee");
        Console.WriteLine("\nNames List:");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }


        // using a Dictionary
        Dictionary<int, string> employees = new();
        employees.Add(1, "John");
        employees.Add(2, "Jane");
        employees.Add(3, "Mary");
        employees.Add(4, "Lee");
        employees.Add(5, "Fred");

        Console.WriteLine("\nEmployees Dictionary:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"Key: {employee.Key}, Value: {employee.Value}");
        }
    }
}

namespace i_stack_contains;

class Program
{
    static void Main(string[] args)
    {
        
        Stack<string> names= new Stack<string>();
        names.Push("Rabi");
        names.Push("Ram");
        names.Push("Ravi");

        Console.WriteLine(names.Contains("Rabi"));
        Console.WriteLine(names.Contains("Kushal"));

    }
}

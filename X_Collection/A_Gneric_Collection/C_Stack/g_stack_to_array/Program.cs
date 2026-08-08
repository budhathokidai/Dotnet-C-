namespace g_stack_to_array;

class Program
{
    static void Main(string[] args)
    {
        
        Stack<string> names=new Stack<string>();
        names.Push("Hello");
        names.Push("Hi");
        names.Push("Ram");
        names.Push("Hari");

        string[] arr = names.ToArray();

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}

/*Hari
Ram
Hi
Hello*/
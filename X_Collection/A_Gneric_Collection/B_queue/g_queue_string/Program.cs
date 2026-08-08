namespace g_queue_string;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();

        names.Enqueue("Ram");
        names.Enqueue("Shyam");
        names.Enqueue("Hari");
        names.Enqueue("Radha");
        names.Enqueue("Hello");
        names.Enqueue("Hi");
        names.Enqueue("Bye bye");

        Console.WriteLine("The number of elements in the queue = " + names.Count);

        Console.WriteLine("The first element in the queue = " + names.Peek());

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}

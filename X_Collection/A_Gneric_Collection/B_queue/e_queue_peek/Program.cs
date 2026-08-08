namespace e_queue_peek;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> names = new Queue<string>();
        names.Enqueue("Ram");
        names.Enqueue("Hari");
        names.Enqueue("Shyam");
        Console.WriteLine("The first element in the queue: " + names.Peek()); //Looks at the first element without removing it.
        
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }
}

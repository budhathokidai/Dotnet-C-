namespace a_queue_enqueue;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue("Ram");
        queue.Enqueue("10");
        queue.Enqueue("12.34");
        queue.Enqueue(true);
        Console.WriteLine("Peek elemnt:"+queue.Peek());
        Console.WriteLine("Queue contains:"+ queue.Contains("Ram"));
        Console.WriteLine("Queue Elements are:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }


        /* queue.Dequeue();
        Console.WriteLine("After dequeue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        } */

    }
}

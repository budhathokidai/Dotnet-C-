namespace a_queue_t;

class Program
{
    static void Main(string[] args)
    {
        /* Queue<int> nums= new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(3);
        nums.Enqueue(2333);
        nums.Enqueue(287);
        nums.Dequeue();
        foreach(var item in nums)
        {
            Console.WriteLine(item);
        } */

        //contain
        /* Console.WriteLine(nums.Contains(3));
        Console.WriteLine(nums.Contains(45));
 */

        //queue_t_string
        Queue<string> names= new Queue<string>();
        {
            names.Enqueue("Ram");
            names.Enqueue("shyam");
            names.Enqueue("Hari");
            names.Enqueue("Radha");
            names.Enqueue("Hello");
            names.Enqueue("Hi");
            names.Enqueue("Bye bye");
            Console.WriteLine("The number of elements in the queue"+names.Count);
            Console.WriteLine("The first element in the queue = "+names.Peek());
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            
        }
        
    }
}

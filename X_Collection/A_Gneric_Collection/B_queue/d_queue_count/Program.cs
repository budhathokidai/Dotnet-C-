namespace d_queue_count;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(22);
        nums.Enqueue(26);
        nums.Enqueue(76);

        Console.WriteLine("The number of elements in the queue: " + nums.Count);
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

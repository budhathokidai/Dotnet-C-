namespace c_Dequeue;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> nums = new Queue<int>();
        nums.Enqueue(23);
        nums.Enqueue(22);
        nums.Enqueue(26);
        nums.Enqueue(76);
        //FIFO = First In, First Out
        nums.Dequeue();

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

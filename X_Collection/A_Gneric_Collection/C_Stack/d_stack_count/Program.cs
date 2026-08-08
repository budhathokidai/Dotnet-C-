namespace d_stack_count;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums = new Stack<int>();
        nums.Push(45);
        nums.Push(65);
        nums.Push(5);
        nums.Push(4);

        Console.WriteLine("Number of elements in stack: " + nums.Count);
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

/*Number of elements in stack: 4
4
5
65
45*/

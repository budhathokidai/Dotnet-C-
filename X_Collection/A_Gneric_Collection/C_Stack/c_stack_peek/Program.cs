namespace c_stack_peek;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums = new Stack<int>();
        nums.Push(45);
        nums.Push(65);
        nums.Push(5);
        nums.Push(4);

        Console.WriteLine("Top element in stack: " + nums.Peek());
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}


/*
Top element in stack: 4
4
5
65
45*/
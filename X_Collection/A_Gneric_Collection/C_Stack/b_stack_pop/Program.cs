namespace b_stack_pop;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums=new Stack<int>();  //LIFO
        nums.Push(34);
        nums.Push(33);
        nums.Push(3);
        nums.Pop();
        foreach(var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

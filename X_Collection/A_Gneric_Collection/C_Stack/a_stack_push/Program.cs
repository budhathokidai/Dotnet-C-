namespace a_stack_push;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> nums=new Stack<int>();  //LIFO
        nums.Push(34);
        nums.Push(33);
        nums.Push(3);
        foreach(var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

/*3
33
34*/

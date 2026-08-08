namespace f_stack_clear;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> myNums = new Stack<int>();

        myNums.Push(23);
        myNums.Push(4);
        myNums.Push(6);

        myNums.Clear();  //Clear() removes all elements from the stack.

        Console.WriteLine("Total elements = " + myNums.Count);
    }
}


/*Total elements = 0*/
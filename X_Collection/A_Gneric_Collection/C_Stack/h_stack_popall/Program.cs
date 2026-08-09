namespace h_stack_popall;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] { 23, 43, 54, 65, 76 };

        Stack<int> myNums = new Stack<int>(arr);

        Console.WriteLine("Total elements in stack = " + myNums.Count);

        while (myNums.Count > 0)
        {
            Console.WriteLine("Removed = " + myNums.Pop());
        }

        Console.WriteLine("Total elements in stack = " + myNums.Count);

    }
}


/*Total elements in stack = 5
Removed = 76
Removed = 65
Removed = 54
Removed = 43
Removed = 23
Total elements in stack = 0*/
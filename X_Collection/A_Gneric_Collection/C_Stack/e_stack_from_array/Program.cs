namespace e_stack_from_array;

class Program
{
    static void Main(string[] args)
    {
        int[] MyArray = new int[] { 1, 4, 2, 33, 4, 5 };
        Stack<int> array = new Stack<int>(MyArray);

        Console.WriteLine("Total elements = " + array.Count);

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}


/*Total elements = 6
5
4
33
2
4
1*/
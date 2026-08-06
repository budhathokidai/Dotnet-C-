namespace l_List_IndexOf;
//Returns the index of an element.
class Program
{
    static void Main(string[] args)
    {
        var nums = new List<int>()
        {
            12,
            3,
            4,
            45,
            32
        };

        Console.WriteLine(nums.IndexOf(45));
        Console.WriteLine(nums.IndexOf(100));
        Console.WriteLine(nums.IndexOf(12));
    }
}

/*3
-1
0*/
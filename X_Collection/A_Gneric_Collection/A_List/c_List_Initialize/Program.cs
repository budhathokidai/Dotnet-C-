namespace c_List_Initialize;

class Program
{
    static void Main(string[] args)
    {
         var nums = new List<int>()
        {
            23,
            32,
            3,
            4
        };

        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
        Console.WriteLine(nums[3]);
    }
}

/*23
32
3
4*/
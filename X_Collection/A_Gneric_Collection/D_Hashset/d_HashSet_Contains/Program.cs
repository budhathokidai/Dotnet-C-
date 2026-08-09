namespace d_HashSet_Contains;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums = new HashSet<int> { 10, 20, 30, 40 };


        Console.WriteLine(nums.Contains(10));
        Console.WriteLine(nums.Contains(50));

    }
}
/*True
False*/
namespace e_HashSet_Count;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums=new HashSet<int>(){12,23,45,221};
        Console.WriteLine("Total Elements in set: "+nums.Count);
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}

/*Total Elements in set: 4
12
23
45
221*/
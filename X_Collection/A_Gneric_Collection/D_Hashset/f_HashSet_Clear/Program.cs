namespace f_HashSet_Clear;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums=new HashSet<int>(){12,23,45,221};
        Console.WriteLine("Total Elements in set before clearing: "+nums.Count);
        
        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
        nums.Clear();
        Console.WriteLine("Total Elements after clear:"+nums.Count);
    }
}

/*Total Elements in set before clearing: 4
12
23
45
221
Total Elements after clear:0*/
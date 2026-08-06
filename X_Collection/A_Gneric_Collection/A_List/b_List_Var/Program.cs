namespace b_List_Var;

class Program
{
    static void Main(string[] args)
    {
        var nums = new List<int>();

        nums.Add(34);
        nums.Add(3);
        nums.Add(23);

        Console.WriteLine(nums[0]);
        Console.WriteLine(nums[1]);
        Console.WriteLine(nums[2]);
    }
}


/*34
3
23*/
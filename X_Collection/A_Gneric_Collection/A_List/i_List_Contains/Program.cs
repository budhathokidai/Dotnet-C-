namespace i_List_Contains;
//Checks whether a specific element exists in the list.
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

        Console.WriteLine(nums.Contains(45));
        Console.WriteLine(nums.Contains(100));
    }
}

/*True
False*/

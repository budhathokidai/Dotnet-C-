namespace h_List_Count;

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

        Console.WriteLine("Total Elements = " + nums.Count);
    }
}

/*Total Elements = 5*/
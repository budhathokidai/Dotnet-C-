namespace k_List_Reverse;

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

        nums.Reverse();

        nums.ForEach(x => Console.WriteLine(x));
    }
}


/*32
45
4
3
12*/
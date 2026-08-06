namespace d_List_Insert;

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

        nums.Insert(0, 34);

        nums.ForEach(x => Console.WriteLine(x));
    }
}

/*34
12
3
4
45
32*/

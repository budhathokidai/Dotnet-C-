namespace j_List_Sort;

class Program
{
    static void Main(string[] args)
    {
         var nums = new List<int>()
        {
            45,
            12,
            3,
            32,
            4
        };

        nums.Sort();

        nums.ForEach(x => Console.WriteLine(x));

    }
}
/*
3
4
12
32
45*/
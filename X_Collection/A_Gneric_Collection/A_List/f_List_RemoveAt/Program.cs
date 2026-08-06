namespace f_List_RemoveAt;

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

        nums.RemoveAt(2);  //indexing Remove

        nums.ForEach(x => Console.WriteLine(x));
    }
}


/*12
3
45
32*/
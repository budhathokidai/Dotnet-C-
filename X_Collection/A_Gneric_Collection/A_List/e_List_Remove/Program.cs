namespace e_List_Remove;

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

        nums.Remove(45);

        nums.ForEach(x => Console.WriteLine(x));
    }
}


/*12
3
4
32*/
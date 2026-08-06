namespace m_List_Find;
//Finds the first element that matches a condition.
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

        int result = nums.Find(x => x > 20);

        Console.WriteLine(result);
    }
}

/*
45*/
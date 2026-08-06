namespace n_List_FindAll;
//Finds all elements that satisfy a condition.
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
            32,
            22,
            15
        };

        var result = nums.FindAll(x => x > 20);

        result.ForEach(x => Console.WriteLine(x));  //Print every element in the result list one by one.
    }
}

/*
45
32
22*/

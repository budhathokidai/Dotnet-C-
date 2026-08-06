namespace o_List_Copy;
//Copies one list into another.
class Program
{
    static void Main(string[] args)
    { var nums = new List<int>()
        {
            12,
            3,
            4,
            45,
            32
        };

        List<int> copy = new List<int>(nums);

        copy.ForEach(x => Console.WriteLine(x));
    }
}

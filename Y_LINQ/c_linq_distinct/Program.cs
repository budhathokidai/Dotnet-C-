namespace c_linq_distinct;

class Program
{
    static void Main(string[] args)
    {
        int[] num = { 12, 32, 3, 4, 21, 34, 32, 122, 22, 3, 4 };

        int uniqueNum = num.Distinct().Count();

        Console.WriteLine("Number of unique elements: " + uniqueNum);
    }
}

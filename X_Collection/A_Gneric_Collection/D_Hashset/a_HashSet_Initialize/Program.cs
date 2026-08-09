namespace a_HashSet_Initialize;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums = new HashSet<int> { 12, 23, 3, 2, 4, 3, 5, 4, 6, 5 };   //HashSet is a collection used to store unique values.

        Console.WriteLine("Elements in HashSet:");

        foreach (var item in nums)
        {
            Console.WriteLine(item);
        }
    }
}


/*Elements in HashSet:
12
23
3
2
4
5
6*/
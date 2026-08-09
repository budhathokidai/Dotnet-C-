namespace c_HashSet_Remove;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums = new HashSet<int>{10, 20, 30, 40};

            nums.Remove(30);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
    }
}
/*10
20
40*/
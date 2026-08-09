namespace b_HashSet_Add;

class Program
{
    static void Main(string[] args)
    {
        HashSet<int> nums = new HashSet<int>();

            nums.Add(10);
            nums.Add(20);
            nums.Add(30);
            nums.Add(20);

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
    }
}

/*10
20
30*/
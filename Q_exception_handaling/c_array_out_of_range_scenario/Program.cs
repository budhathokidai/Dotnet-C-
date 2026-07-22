namespace c_array_out_of_range_scenario;

class Program
{
    static void Main(string[] args)
    {
        int[] nums=new int[5];
        nums[10]=30;
        Console.WriteLine(nums[10]);
    }
}

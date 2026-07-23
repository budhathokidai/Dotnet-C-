namespace d_array_out_exception_handling;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[5];
        try
        { 
            /* nums[3] = 8;
            Console.WriteLine(nums[3]); */
            nums[10] = 30;
            Console.WriteLine(nums[10]);
        }
        catch (Exception e)
        //catch(IndexOutOfRangeException.e)
        {
            Console.WriteLine("Out of range!" + e);
        }

    }
}

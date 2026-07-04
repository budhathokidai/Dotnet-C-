namespace g_array_operation;

class Program
{
    static void Main(string[] args)
    {
        int [] myarray={1,45,5,6,4,3,2};
        Console.WriteLine("Minimum value:"+myarray.Min());
        Console.WriteLine("Maximum value:"+myarray.Max());
        Console.WriteLine("Sum value:"+myarray.Sum());
        Console.WriteLine("Average value:"+myarray.Average());

    }
}

namespace g_array_operation;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers={1,23,4,4,5,6,34,56,4564,456,456};
        Console.WriteLine("Maximum value form numbers:"+numbers.Max());
        Console.WriteLine("Minimum value form numbers:"+numbers.Min());
        Console.WriteLine("Sum of all array elements:"+numbers.Sum());
        Console.WriteLine("Average of all array elements:"+numbers.Average());
    }
}

/*
Maximum value form numbers:4564
Minimum value form numbers:1
Sum of all array elements:5609
Average of all array elements:509.90909090909093*/
namespace d_type_byte_signed;


class Program
{
    static void Main(string[] args)
    {
        // sbyte is a signed 8-bit integer type
        // Range: -128 to 127

        sbyte number = 120;

        Console.WriteLine("Starting Value: " + number);

        // Increasing value step by step
        number++;
        Console.WriteLine("After Increment 1: " + number);

        number++;
        Console.WriteLine("After Increment 2: " + number);

        // Moving close to upper limit
        number = 127;
        Console.WriteLine("Max Limit Value: " + number);

        // Overflow happens here (127 + 1 becomes -128)
        number++;
        Console.WriteLine("After Overflow: " + number);

        // Continuing overflow cycle
        number++;
        Console.WriteLine("After Wrap Around: " + number);
    }
}

/*Starting Value: 120
After Increment 1: 121
After Increment 2: 122
Max Limit Value: 127
After Overflow: -128
After Wrap Around: -127*/

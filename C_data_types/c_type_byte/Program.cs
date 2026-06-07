namespace c_type_byte;
class Program
{
    static void Main(string[] args)
    {
        // byte is an unsigned 8-bit data type
        // range: 0 to 255 (values hold by byte)

        byte value = 10;

        Console.WriteLine("Initial Value: " + value);

        // Increasing value step by step
        value++;
        Console.WriteLine("After Increment 1: " + value);

        value++;
        Console.WriteLine("After Increment 2: " + value);

        // Setting value near maximum limit
        value = 250;
        Console.WriteLine("Reset Value: " + value);

        // This will cause overflow (255 + 1 wraps back to 0)
        value++;
        Console.WriteLine("After Overflow: " + value);

        value++;
        Console.WriteLine("After Wrap Around: " + value);
    }
}


/*Initial Value: 10
After Increment 1: 11
After Increment 2: 12
Reset Value: 250
After Overflow: 251
After Wrap Around: 252*/
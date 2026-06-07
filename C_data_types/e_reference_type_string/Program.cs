namespace e_reference_type_string;


class Program
{
    static void Main(string[] args)
    {
        // string is a reference type used to store text
        string b = "Namaste";
        Console.WriteLine("Initial String: " + b);

        // Adding more text using += operator
        b += " Sanothimi";
        Console.WriteLine("After First Append: " + b);

        // Another way of joining strings using +
        b = b + " Bhaktapur";
        Console.WriteLine("After Second Append: " + b);
    }
}

/*Initial String: Namaste
After First Append: Namaste Sanothimi
After Second Append: Namaste Sanothimi Bhaktapur*/

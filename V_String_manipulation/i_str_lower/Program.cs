namespace i_str_lower;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Sanu";
        string str2 = str1.ToLower();
        Console.WriteLine("Original string = " + str1);
        Console.WriteLine("Converted lowercase string = " + str2);
    }
}

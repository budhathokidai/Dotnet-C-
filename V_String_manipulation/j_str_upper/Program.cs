namespace j_str_upper;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Nanu";
        string str2 = str1.ToUpper();
        Console.WriteLine("Original string = " + str1);
        Console.WriteLine("Converted lowercase string = " + str2);
    }
}

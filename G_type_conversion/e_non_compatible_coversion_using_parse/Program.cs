namespace e_non_compatible_coversion_using_parse;

class Program
{
    static void Main(string[] args)
    {
        string a="234";
        int b=int.Parse(a);
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}
/*234
234*/

/* Every data type has a parse method
Byte.Parse();
short.Parse();
int.Parse();
bool.Parse(); */
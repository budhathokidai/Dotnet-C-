namespace h_stringBuilder_to_String;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello Sanothimi");

        string str = s.ToString();

        Console.WriteLine(str);
    }
}

/*Hello Sanothimi*/
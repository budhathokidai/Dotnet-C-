using System.Text;

namespace f_string_builder_replace;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s= new StringBuilder("Hello, Bhaktapur");

        s.Replace("Bhaktapur", "Sanothimi");

        Console.WriteLine(s);
    }
}

/*Hello, Sanothimi*/
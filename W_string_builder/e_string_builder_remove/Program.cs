using System.Text;

namespace e_string_builder_remove;

class Program
{
    static void Main(string[] args)
    {
       StringBuilder s= new StringBuilder("Hello, Welcome Rabi Budhathoki", 30);

        s.Remove(5, 9); // Means start removing from index 5 Remove 9 characters

        Console.WriteLine(s);
    }
}

/*Hello Rabi Budhathoki*/
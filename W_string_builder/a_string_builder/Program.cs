using System.Text;

namespace a_string_builder;
//StringBuilder in C# is a class from the System.Text namespace that is used to efficiently create and modify strings. Unlike the string type, which is immutable (cannot be changed after creation), StringBuilder allows you to modify the same object without creating new string instances.
class Program
{
    static void Main(string[] args)
    {
        StringBuilder s= new StringBuilder("Hello Rabi Budhathoki");
        Console.WriteLine(s);
    }
}

/*Hello Rabi Budhathoki*/
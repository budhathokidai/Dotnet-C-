namespace g_stringTostringBuilder;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";

        StringBuilder s = new StringBuilder(str);

        Console.WriteLine(s);
    }
}
  
  /*Hello*/

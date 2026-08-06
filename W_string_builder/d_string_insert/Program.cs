using System.Text;

namespace d_string_insert;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder("Hello",20);
         s.Insert(2, "Rabi");
        Console.WriteLine(s);
    }
}

/*HeRabillo*/
using System.Text;

namespace b_string_append;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder s=new StringBuilder("Hello rabi ");
        //s,.Append(9.9);
        s.AppendFormat("{0:c}",9.9);
        Console.WriteLine(s);
    }
}
/*Hello rabi £9.90*/
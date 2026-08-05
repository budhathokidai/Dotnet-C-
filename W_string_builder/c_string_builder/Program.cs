using System.Text;
namespace c_string_builder;

class Program
{
    static void Main(string[] args)
    {

        const int MaxSize = 50;
        StringBuilder s = new StringBuilder();
        void AppendwithLimit(string text)
        {
            if (s.Length + text.Length > MaxSize)
            {
                Console.WriteLine("Cnnot append: Size limit reached!");
                return;
            }
            s.Append(text);
        }
        AppendwithLimit("Hello ");
        AppendwithLimit(" Rabi ");
        AppendwithLimit(new string('x', 10));
        AppendwithLimit(new string('x', 40));
        Console.WriteLine(s.ToString());


    }
}

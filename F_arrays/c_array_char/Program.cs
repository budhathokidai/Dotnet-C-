namespace c_array_char;

class Program
{
    static void Main(string[] args)
    {
        char[] character={'R','A','B','I'};
        foreach(var num in character)
        {
            Console.Write("\t{0}",num);
        }
    }
}
/*    R       A       B       I*/
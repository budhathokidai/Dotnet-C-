namespace c_char_array;

class Program
{
    static void Main(string[] args)
    {
         // array of characters
        char[] namearray = { 'R', 'a', 'b','i' };
        string name = new string(namearray);
        Console.WriteLine(name);
    }
}

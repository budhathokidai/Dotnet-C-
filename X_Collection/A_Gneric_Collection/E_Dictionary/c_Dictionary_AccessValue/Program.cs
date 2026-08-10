namespace c_Dictionary_AccessValue;
//You can directly access a value using its key.
class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

            Console.WriteLine(rollnames[23]);
            Console.WriteLine(rollnames[25]);
    }
}

/*Ram
Shyam*/
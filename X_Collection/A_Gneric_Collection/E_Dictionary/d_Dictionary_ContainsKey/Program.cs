namespace d_Dictionary_ContainsKey;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

            Console.WriteLine(rollnames.ContainsKey(23));
            Console.WriteLine(rollnames.ContainsKey(30));
    }
}

/*True
False*/
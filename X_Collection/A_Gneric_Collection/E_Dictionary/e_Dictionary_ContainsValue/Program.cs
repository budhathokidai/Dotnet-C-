namespace e_Dictionary_ContainsValue;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

            Console.WriteLine(rollnames.ContainsValue("Hari"));
            Console.WriteLine(rollnames.ContainsValue("Sita"));
    }
}

/*True
False*/
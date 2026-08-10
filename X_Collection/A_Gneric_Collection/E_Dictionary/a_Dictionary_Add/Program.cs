namespace a_Dictionary_Add;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();
        rollnames.Add(23, "Ram");
        rollnames.Add(24, "Hari");
        rollnames.Add(25, "Shyam");

        foreach (var item in rollnames)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
    }
}
/*23
Ram
24
Hari
25
Shyam*/
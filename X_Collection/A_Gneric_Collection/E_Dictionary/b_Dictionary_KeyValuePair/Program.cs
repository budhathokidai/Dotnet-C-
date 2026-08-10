namespace b_Dictionary_KeyValuePair;

class Program
{
    static void Main(string[] args)
    {
         Dictionary<int, string> rollnames = new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

            foreach (KeyValuePair<int, string> kvp in rollnames)
            {
                Console.WriteLine("Key is {0} and the value is {1}",kvp.Key,kvp.Value);
            }
    }
}

/*Key is 23 and the value is Ram
Key is 24 and the value is Hari
Key is 25 and the value is Shyam*/
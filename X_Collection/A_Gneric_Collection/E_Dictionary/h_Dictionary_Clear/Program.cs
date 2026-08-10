namespace h_Dictionary_Clear;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames =new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

            Console.WriteLine("Before Clearance:");
            Console.WriteLine("Total elements = " + rollnames.Count);

            rollnames.Clear();
            Console.WriteLine("After Clearance:");
            Console.WriteLine("Total elements = " + rollnames.Count);

    }
}

/*Before Clearance:
Total elements = 3
After Clearance:
Total elements = 0*/
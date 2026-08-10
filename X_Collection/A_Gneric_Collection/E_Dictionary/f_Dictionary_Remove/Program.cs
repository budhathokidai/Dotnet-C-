namespace f_Dictionary_Remove;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> rollnames = new Dictionary<int, string>();

            rollnames.Add(23, "Ram");
            rollnames.Add(24, "Hari");
            rollnames.Add(25, "Shyam");

           Console.WriteLine("Before Remove");
            foreach (var item in rollnames)
            {

                Console.WriteLine(item.Key + " = " + item.Value);
            }
            rollnames.Remove(24);
            Console.WriteLine("After Remove");
            foreach (var item in rollnames)
            {

                Console.WriteLine(item.Key + " = " + item.Value);
            }
    }
}


/*Before Remove
23 = Ram
24 = Hari
25 = Shyam
After Remove
23 = Ram
25 = Shyam*/

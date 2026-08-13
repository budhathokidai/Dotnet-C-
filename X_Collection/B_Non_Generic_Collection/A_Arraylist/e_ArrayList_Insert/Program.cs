namespace e_ArrayList_Insert;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList namelist = new ArrayList();

        namelist.Add("Rabi");
        namelist.Add("Hari");
        namelist.Add("Ram");
        namelist.Add("Shyam");

        Console.WriteLine("===== Original List =====");

       for(int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }

        // Insert() is used to add an element at a specific index
        namelist.Insert(1, "John");

        Console.WriteLine("===== Updated List =====");

         for(int i = 0; i < namelist.Count; i++)
        {
            Console.WriteLine(namelist[i]);
        }
    }
}

/*===== Original List =====
Rabi
Hari
Ram
Shyam
===== Updated List =====
Rabi
John
Hari
Ram
Shyam*/
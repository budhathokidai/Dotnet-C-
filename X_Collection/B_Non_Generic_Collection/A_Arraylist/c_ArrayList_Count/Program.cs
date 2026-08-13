namespace c_ArrayList_Count;

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

        Console.WriteLine("Total elements = " + namelist.Count);
    }
}

/*Total elements = 4*/
namespace g_ArrayList_RemoveAt;

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

        // RemoveAt() is used to remove an element using its index
        namelist.RemoveAt(1);

        foreach (var item in namelist)
        {
            Console.WriteLine(item);
        }
    }
}

/*Rabi
Ram
Shyam*/
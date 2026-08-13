namespace d_ArrayList_Access;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        
            ArrayList namelist = new ArrayList();
            namelist.Add("Rabi");
            namelist.Add("Hari");
            namelist.Add("Ram");
            Console.WriteLine(namelist[0]);
            Console.WriteLine(namelist[1]);
            Console.WriteLine(namelist[2]);
    }
}

/*Rabi
Hari
Ram*/
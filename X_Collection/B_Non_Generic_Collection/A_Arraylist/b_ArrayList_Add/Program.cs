namespace b_ArrayList_Add;

using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        ArrayList namelist = new ArrayList();

        namelist.Add("Rabi");
        namelist.Add("Hari");
        namelist.Add("24");
        namelist.Add("45.6");

        foreach (var item in namelist)
        {
            Console.WriteLine(item);
        }
    }
}

/*Rabi
Hari
24
45.6*/
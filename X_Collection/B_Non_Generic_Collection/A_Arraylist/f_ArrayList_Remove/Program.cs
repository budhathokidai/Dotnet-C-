namespace f_ArrayList_Remove;

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

        // Remove() is used to remove an element by its value
        namelist.Remove("Ram");
        foreach (var item in namelist)
        {
            Console.WriteLine(item);
        }
    }
}
/*Rabi
Hari
Shyam*/

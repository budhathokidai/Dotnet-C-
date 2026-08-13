namespace r_sortedlist_tk_tv;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> rollnames = new SortedList<int, string>();
        rollnames.Add(1, "Ram");
        rollnames.Add(4, "Ramu");
        rollnames.Add(2, "Ramuu");
        rollnames.Add(5, null);
        rollnames.Add(3, "Ramuuuu");

       /*  //following will throw exception
        rollnames.Add("Shyam",23);//compile time exception
        rollnames.Add(1,"Hary");  //run time exception
        rollnames.Add(null,"Appy"); */

        rollnames[5]="Hira"; //assign with a value if value is not thera
        rollnames[3]="Hira bete"; //updatea a value
        Console.WriteLine(rollnames[4]);  //only for value

        foreach (var item in rollnames)
        {
            Console.WriteLine("Key is {0} and value is {1}", item.Key, item.Value);
        }

    }
}

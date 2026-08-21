namespace a_linq;
#nullable disable
class Program
{
    static void Main(string[] args)
    {
         string[] students = { "Rabi", "Kushal", "Ram", "Rama" };
        var nameSort = from name in students
                       orderby name
                       select name;  //linq
        foreach (var name in nameSort)
        {
            Console.WriteLine(name);
        } 
    }
}

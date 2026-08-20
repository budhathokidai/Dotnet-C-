namespace f_linq_string_contains;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "Ram", "Hari", "Rabi", "Sita" };

        var myLinqQuery =
            from name in names
            where name.Contains("r")
            select name;

        foreach (var item in myLinqQuery)
        {
            Console.WriteLine(item);
        }
    }
}
/*Hari*/
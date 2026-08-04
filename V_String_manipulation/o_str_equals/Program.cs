namespace o_str_equals;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Rabi";
        string name2 = "Hari";
        string name3 = "Rabi";
        
        //The Equals() method checks whether two strings have the same sequence of characters.
        bool result1 = name1.Equals(name2);
        bool result2 = name1.Equals(name3);

        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}

/*False  //They are different, so the result is False.
True    //They are the same, so the result is True.
*/
namespace l_str_clone;

class Program
{
    static void Main(string[] args)
    {
        string str1 = "Rabi";
        string str2 = (string)str1.Clone();
        Console.WriteLine("Source string = " + str1);
        Console.WriteLine("Cloned string = " + str2);
    }
}
/*Source string = Rabi
Cloned string = Rabi*/
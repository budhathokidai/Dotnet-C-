namespace f_str_fname_lname_address;

class Program
{
    static void Main(string[] args)
    {
        string fnaame = "Heri";
        string lnaame = "Bahadur";
        string address = "KTM";
        Console.WriteLine(fnaame + " " + lnaame + "lives in" + address);
        Console.WriteLine("{0} {1} lives in {2}", fnaame, lnaame, address);
    }
}

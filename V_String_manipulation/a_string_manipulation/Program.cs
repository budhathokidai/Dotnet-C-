namespace a_string_manipulation;

class Program
{
    static void Main(string[] args)
    {
        //printing string within double quoote
        Console.WriteLine("Hello");

        //printing string from variable
        string name = "Sanothimi";
        Console.WriteLine(name);

        //arrayu of character
        char[] myarray = { 'R', 'a', 'b' };
        string nme = new string(myarray);
        Console.WriteLine(nme);

        //concatinate
        string fname = "Ram";
        string lname = "nam";
        string fulname = fname + " " + lname;
        Console.WriteLine(fulname);

        //escape
        Console.WriteLine("Hello\nRabi");
        Console.WriteLine("Hello\tRabi");
        Console.WriteLine("\"Hello Rabi\"");
        Console.WriteLine("C:\\Hello\\ Rabi");

        string fnaame = "Heri";
        string lnaame = "Bahadur";
        string address = "KTM";
        Console.WriteLine(fnaame + " " + lnaame + "lives in" + address);
        Console.WriteLine("{0} {1} lives in {2}", fnaame, lnaame, address);

        //string length
        string clg = "Sanothimi";
        int len = clg.Length;
        Console.WriteLine("Character length of {0} is ={1}", clg);

        //function concatinate
        string surukoname = "Sandy";
        string lnam = "Shrestha";
        Console.WriteLine(string.Concat(surukoname, lnam));

        //string to lower case
        string str1 = "Sandy";
        string str2 = str1.ToLower();
        Console.WriteLine("Original string" + str1);
        Console.WriteLine("After converting to lower" + str2);

    }
}

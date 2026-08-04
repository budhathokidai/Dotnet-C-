namespace k_str_copy;

class Program
{
    static void Main(string[] args)
    {
        string name = "Rabi";
        // string myname = string.Copy(name); // not recommended to use
        string myname= new string(name);
        Console.WriteLine("Source string =" + name);
        Console.WriteLine("Copied string =" + myname);
    }
}

/*Source string = Rabi
Copied string = Rabi*/
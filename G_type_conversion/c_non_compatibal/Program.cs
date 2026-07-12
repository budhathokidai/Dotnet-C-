namespace c_non_compatibal;

class Program
{
    static void Main(string[] args)
    {
        string  a="123";
        int b=Convert.ToInt32(a);          //int b=(int)a (its not possible)
        //int b=int.Parse(a);  Parse method
        int c=354;
        int sum=b+c;
        Console.WriteLine("Sum="+sum);
    }
}

/* Convert Classes
ToByte()
ToInt16() = > short
ToInt32() = > int
ToInt64() = > long */
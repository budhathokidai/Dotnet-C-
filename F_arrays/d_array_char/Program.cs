namespace d_array_char;

class Program
{
    static void Main(string[] args)
    {
        string[] strings={"Ram","Hari","Hami"};
        foreach(var str in strings)
        {
             Console.Write("\t{0}",str);
        }
       
    }
}
/*        Ram     Hari    Hami*/
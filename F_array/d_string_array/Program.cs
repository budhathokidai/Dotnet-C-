namespace d_string_array;

class Program
{
    static void Main(string[] args)
     { 
        string[] myarray={"Rabi","Gita","sita"};
        foreach(var item in myarray)
        {
            Console.WriteLine("{0}\t",item);
        }
      
    }
}

namespace c_char_array;

class Program
{
    static void Main(string[] args)
     { 
        char[] myarray={'r','a','b','i'};
        foreach(var item in myarray)
        {
            Console.WriteLine("{0}\t",item);
        }
      
    }
}

namespace h_string_sort;

class Program
{
    static void Main(string[] args)
     { 
        string[] myarray={"ram","Hari","Sita","Gita"};
        Console.WriteLine("Array before sorting");
        foreach(var item in myarray)
        {
            Console.WriteLine(item);
        }
        Array.Sort(myarray);
        Console.WriteLine("Array after sorting");
        foreach(var item in myarray)
        {
            Console.WriteLine(item);
        }
      
    }
}

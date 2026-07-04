namespace e_sort_array;

class Program
{
    static void Main(string[] args)
     { 
        int[] myarray={100,8,7,45,68,67};
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


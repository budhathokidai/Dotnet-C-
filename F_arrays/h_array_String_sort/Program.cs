namespace h_array_String_sort;

class Program
{
    static void Main(string[] args)
    {
        string[] strings = { "name", "rollno", "address" };
        /*foreach(var str in strings)
        {
            Console.WriteLine(str);
        }
        Array.Sort(strings);
        Console.WriteLine("Strings after sorting");
        foreach(var str in strings)
        {
            Console.WriteLine(str);
        }*/

        int len = strings.Length;

        Console.WriteLine("The number of array element is = " + len);
        Console.WriteLine("\nList of array elements before sorting:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Name {0} is = {1} ", i + 1, strings[i]);
        }
        // Array.Sort(strings); // sorts in ascending order
        Array.Reverse(strings); // sorts in descending order
        Console.WriteLine("\nList of array elements after sorting:");
        for (int i = 0; i < len; i++)
        {
            Console.WriteLine("Name {0} is = {1} ", i + 1, strings[i]);
        }
    }
}
/*List of array elements after sorting:
Name 1 is = address 
Name 2 is = rollno 
Name 3 is = name */
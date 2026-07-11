namespace f_sorting_in_descending_order;

class Program
{
    static void Main(string[] args)
    {
       int[] numbers={1,3,6,4,8,4,45};
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
        //sorting in ascending order
        Array.Sort(numbers);
        //reversing sorted for descending order
        Array.Reverse(numbers);
        Console.WriteLine("After Sorting in descending order");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
/*1
3
6
4
8
4
45
After Sorting in descending order
45
8
6
4
4
3
1*/
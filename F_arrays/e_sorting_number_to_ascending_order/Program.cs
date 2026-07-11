namespace e_sorting_number_to_ascending_order;

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
        Console.WriteLine("After Sorting in ascending order");
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
After Sorting in ascending order
1
3
4
4
6
8
45*/
